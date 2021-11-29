#include <Arduino.h>
#include <PulseSensorPlayground.h>
#include <WiFiNINA.h>
#include <LiquidCrystal.h>

char SSID[] = "MSI9247";
char PASS[] = "gr3wt2h64";
int status = WL_IDLE_STATUS;

int PulseSensorPurplePin = 0;
int Threshold = 550;
int Signaal;

void setup() 
{
	Serial.begin(9600);

	while (status != WL_CONNECTED)
  	{
   		Serial.print("Connecting to WiFi");
    	delay(200);
		Serial.print(".");
		delay(200);
		Serial.print(".");
		delay(200);
		Serial.println(".");
		delay(200);
		status = WiFi.begin(SSID, PASS);
  	}

 	Serial.println("Connected to the WiFi network");
 	Serial.println(WiFi.localIP());
	delay(1000);
}



void loop()
{
	Signaal = analogRead(PulseSensorPurplePin);

	Serial.println(Signaal / 10);	
	delay(300);
}