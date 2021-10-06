// Khuong Viet Tai
/*
 8. Objective(FlowControls)
Write an access control in C# that asks the user for the username and password. Both must be integers and repeat until the login is 12 and the password is 1234 or up to a maximum of 3 attempts.
If the username and password are correct it shows Login successful, but Login failed.


Input:
	1234
	1234
	admin
	admin
	admin
	1234

Output:
	Login failed
	Login failed
	Login failed
*/






using System;
public class AccessControl
{
    public static void Main(string[] args)
    {
        int user, pass;
        int attempts = 0;
 
        do
        {
            user = Convert.ToInt32(Console.ReadLine());
            pass = Convert.ToInt32(Console.ReadLine());
 
            if ((user != 12) || (pass != 1234))
            {
                Console.WriteLine("Login failed");
                attempts++;
            }
        }
        while (((user != 12) || (pass != 1234)) && (attempts != 3));
 
        if ((user == 12) || (pass == 1234))
            Console.WriteLine("Login successful");
    }
}
