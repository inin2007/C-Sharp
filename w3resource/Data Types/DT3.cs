using System;
public class DT3
{
public static void Main()
{
string username, password;
int ctr = 0,dd=0;

do
{
username = "Paul";
password = "Lee";
if( username == "username" && password == "password" )
{
    dd=1;
    ctr=3;
}

else
{
    dd=0;
    ctr++;
}
}
while (( username != "username" || password != "password" )
        && (ctr != 3));
        if (dd == 0)
        {
            Console.Write("\nLogin attemp more than three times. Try later!\n\n");
        }
        else  
        if(dd==1)
        {
            Console.Write("\nPassword entered successfull!\n\n");	}         
    }
}
