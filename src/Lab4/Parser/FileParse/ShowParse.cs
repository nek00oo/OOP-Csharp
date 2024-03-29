using Itmo.ObjectOrientedProgramming.Lab4.Command;
using Itmo.ObjectOrientedProgramming.Lab4.Iterator;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.FlagsParse;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.FlagsParse.FlagArgument;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.FileParse;

public class ShowParse : CommandParserBase
{
    public override ParseResult CheckCommand(IIterator iterator)
    {
        if (iterator.GetCurrent().ToUpperInvariant() == "SHOW" && iterator.MoveNext())
        {
            string fileName = iterator.GetCurrent();
            if (iterator.MoveNext())
            {
                foreach (IFlagParse flagParse in FlagParse)
                {
                    IFlagArgument flagsArgument = flagParse.CheckValue(iterator);
                    if (flagsArgument is OutputModeValue modeValue)
                        return new ParseResult.Success(new ShowFile(fileName, modeValue.Mode));
                }
            }
        }

        return NextCommand?.CheckCommand(iterator) ?? new ParseResult.CommandNotDetected();
    }
}