using System;
using System.Text;




public class TextInput// clase Padre ,acepta todos los caracteres 
{


    StringBuilder myText = new StringBuilder();


    public virtual void Add(char c)//La palabla virtual  es colocada de forma que la clase derivada puede tener su propia implementaciion de la funcion "Add"
    {

        myText.Append(c);

    }


    public string GetValue()
    {
        return myText.ToString();
    }


}

//Numeric  es la  clase derivada y  acepta solo  digitos
public class NumericInput : TextInput
{





    public override void Add(char c)//override debe ser escrita para permitir al sistema reconocer cual es la funcion debe ser usada.
    {

        if (char.IsDigit(c))

        {
            base.Add(c);


        }

    }
}




public class UserInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***************");

        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        Console.WriteLine("***************");
        Console.ReadLine();
        
    }

}
