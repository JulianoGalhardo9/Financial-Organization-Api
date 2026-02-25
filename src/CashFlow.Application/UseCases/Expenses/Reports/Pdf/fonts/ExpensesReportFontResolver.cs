using MigraDoc.DocumentObjectModel;
using PdfSharp.Fonts;

namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf.fonts
{
    public class ExpensesReportFontResolver : IFontResolver
    {
        public byte[]? IFontResolver.GetFont(string faceName)
        {
            throw new NotImplementedException();
        }

        public FontResolverInfo? IFontResolver.ResolveTypeface(string familyName, bool bold, bool italic)
        {
            new Font
            {
                Name = FontHelper.RALEWAY_REGULAR;
            };

            return new FontResolverInfo(familyName);
        }
    }
}

