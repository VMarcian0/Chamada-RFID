#include <SPI.h>
#include <MFRC522.h>
#include <LiquidCrystal.h>

#define SS_PIN 10
#define RST_PIN 9
MFRC522 mfrc522(SS_PIN, RST_PIN);	// Create MFRC522 instance.
LiquidCrystal lcd(6, 7, 5, 4, 3, 2); 

void setup() {
	Serial.begin(9600);	// Initialize serial communications with the PC
	SPI.begin();			// Init SPI bus
	mfrc522.PCD_Init();	// Init MFRC522 card
  pinMode (8, OUTPUT);
  lcd.begin(16, 2);
  int flag = 0;
  limpaLCD();
}

void loop() {
  telaInicial();
	if ( ! mfrc522.PICC_IsNewCardPresent()) {
		return;
	}

	// Select one of the cards
	if ( ! mfrc522.PICC_ReadCardSerial()) {
		return;
	}
      digitalWrite(8,HIGH);
      String conteudo = "";
        for(byte i = 0; i < mfrc522.uid.size; i++)
          conteudo.concat(String(mfrc522.uid.uidByte[i], HEX));
        Serial.println(conteudo);
        delay(1100);
        digitalWrite(8,LOW);
 
}//loop  

void  limpaLCD()
{
  lcd.setCursor(0,0);
  lcd.print("                ");
  lcd.setCursor(0,1);
  lcd.print("                "); 
}
   void serialEvent(){
     String recebido = (String)Serial.readString();
     if(recebido.length()>32)
    {
      //NADA
    }
    else
    {
      int j=0;
      int k=0;
      lcd.setCursor(0,0);
      lcd.print("                 ");
      lcd.setCursor(0,1);
      lcd.print("                 ");
      lcd.setCursor(0,0);
      for(int i=0; i<((recebido.length()-1));i++)
      {
          if(i==15 || recebido[i]=='\r')
          {
              j=1;
              k=i;
              i++;
          }
          if(j==0)
          {
            lcd.setCursor(i,j); 
          }
          if(j==1)
          {
            lcd.setCursor(i-k-1,j);  
          }
          lcd.print(recebido[i]);   
      }
      delay(3000);
      limpaLCD();  
   }
}
void telaInicial(){
  lcd.setCursor(0,0);
  lcd.print("CHAMADA RFID");
  lcd.setCursor(0,1);
  lcd.print("V 1.2a"); 
}
