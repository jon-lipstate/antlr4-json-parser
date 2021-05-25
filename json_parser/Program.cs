using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using antlr_test.Abstract;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

public partial class jsonParser
{
    public IValue Run()
    {
        return _builder.Build();
        //return null;
    }
}
namespace antlr_test
{
    class Program
    {

        static void Main(string[] args)
        {
            var test = "{\"name\":\"odie\"}";
            AntlrInputStream input = new AntlrInputStream(test);
            /*
            ITokenSource lexer = new jsonLexer(input);
            ITokenStream tokens = new CommonTokenStream(lexer);
            
            var parser = new jsonParser(tokens);
            IParseTree tree = parser.compileUnit();
            */
            //https://stackoverflow.com/questions/43868100/antlr4-parser-c-sharp-project-simple-arithmetics
            var lex = new global::jsonLexer(new AntlrInputStream(test));
            ITokenStream tk = new CommonTokenStream(lex);
            var par = new global::jsonParser(tk);
            var tree = par.compileUnit();
            var iv  = par.Run();
            

            Console.ReadKey();

        }
    }
}
