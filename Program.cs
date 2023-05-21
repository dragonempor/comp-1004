namespace signup
{
    using System;
    using System.IO;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;
    using System.ComponentModel.Design;
    using System.Xml;

    namespace FiileStream {
        public class Login
        {
             
            static void Main(string[] args)
            {
                    
                string username, password;
                int ctr = 0;
                Console.Write("what is your  dection A for login or  B for sign up routine ");
                string dection;
                dection = Console.ReadLine();
                dection = dection.ToUpper();
                var path = ("C:\\Users\\rokwo\\source\\repos\\ConsoleApp1\\Accounts-text-docs.txt");
                var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //var sw = new StreamWriter(fs);
                var sr = new StreamReader(fs);
                var text = sr.ReadToEnd();
            
                if (dection == "B")
                {
                    string usename = sr.ReadToEnd();
                    Console.WriteLine("please input your usename");
                    username = Console.ReadLine();
                    Console.WriteLine("please input your password");
                    password = Console.ReadLine();
                
                    if (text.Contains(username))
                    {
                        Console.WriteLine("usename in use");
                        fs.Close();
                        ctr++;
                    }
                    else 
                    {
                     //   var lob = ("\n",text,"\n",usename,"\n",password);
                        string hub = ("\n" + password);
                        Console.WriteLine(hub);

                        fs.Close();
                        File.WriteAllText(path, hub);
                    
                            
                        //this section stores the usename and password into the text file 
                       
                        if (text.Contains(username))
                        {
                            //this section returns true if the usename and password have been stored sucsefully 
                            Console.WriteLine("usename inputed succsesfully ");
                           
                        }
                        fs.Close();
                    }
                 }
                 if (dection == "A") 
                 {
                    
                    while (ctr!=3)
                    {
                        Console.WriteLine("please input your username");
                        username = Console.ReadLine();

                        if (text.Contains(username))
                        {
                            Console.WriteLine("please input your password");
                            password = Console.ReadLine();
                            if (text.Contains(password))
                            {
                                Console.WriteLine("welcome");
                                ctr = 3;
                            }


                        }
                        else 
                        {
                            Console.WriteLine("please try agin");
                            ctr++;
                           
                        }
                    }
                 }
            }
        }
    }
}