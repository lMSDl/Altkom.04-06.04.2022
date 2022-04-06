namespace DesignPatterns.Behavioral.Visitor.I
{
    public interface IVisitor
    {
        void Visit(Hyperlink hyperlink);
        void Visit(BoldText boldText);
        void Visit(PlainText plainText);
    }
}