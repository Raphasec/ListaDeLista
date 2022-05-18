public class Ex10{
    public void Answer()
    {
        List<char> mapa = new List<char>();
        mapa.AddRange(new char[] { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
        List<char> frase = new List<char>() { 'V', 'O', 'U', ' ', 'C', 'O', 'N', 'S', 'E', 'G', 'U', 'I', 'R' };
        List<string> criptografia = new List<string>();
        foreach (char caractere in frase)
        {
            criptografia.Add(mapa.IndexOf(caractere).ToString("D2"));
        }
        string textoCriptografia = String.Join("", criptografia);
        Console.WriteLine(textoCriptografia);

        //decriptografia
        for (int i = 0; i < textoCriptografia.Length; i += 2)
        {
            //dois caracteres correspondentes ao caractere 
            //criptografado
            string textoCaractere =
                textoCriptografia[i].ToString() + 
                textoCriptografia[i + 1].ToString();
            //posição do caractere no mapa
            int codigoCaractere = Convert.ToInt32(textoCaractere);
            //decriptografa a letra a partir do mapa
            char letra = mapa[codigoCaractere];
            //mostra a letra
            Console.Write(letra);
        }

        Console.WriteLine($"\n\n\n{criptografia.IndexOf("05").ToString("D-5")}");
    }
}
