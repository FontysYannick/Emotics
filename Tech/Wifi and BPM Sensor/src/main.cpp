#include <Arduino.h>
#include <PulseSensorPlayground.h>
#include <WiFiNINA.h>
using namespace std;

int cout;
int endl;

int main()
{
	for(int x = 1; x<25; x++)
	{
		cout << 1+(rand()%6) << endl;
	}
}


/* char SSID[] = "MSI9247";
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
   		Serial.println("Connecting to WiFi...");
    	status = WiFi.begin(SSID, PASS);
    	delay(500);
  	}

  	Serial.println("Connected to the WiFi network");
  	Serial.println(WiFi.localIP());
	delay(1000);
}

void loop()
{
	Signaal = analogRead(PulseSensorPurplePin);

	Serial.println(Signaal / 10);
	
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
	delay(300);
} */

void setup(){
	Serial.begin(9600);


}

void loop(){
	Serial.println("Hello World");
	Serial.println(cout);

}