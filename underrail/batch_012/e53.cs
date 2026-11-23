using System;
using System.Diagnostics;

// Token: 0x02002157 RID: 8535
[bmq("1.1.0.15_Cc23_ModelChange", "1.1.0.15", "cc23", false)]
public sealed class e53 : fg
{
	// Token: 0x0600C8FA RID: 51450 RVA: 0x0046FC4C File Offset: 0x0046DE4C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("1c58ce8d-f8c9-4773-9f49-fe63740940cb"), A_1.n("cc23")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.a(bln.cz);
					aspect.aa().Gear.l().b(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\PraetorianHeavyArmorTabard")));
				}
			}
			c5x c5x2 = new ar7(new Guid("4901d8b7-6717-4148-9ca4-55eadaef366e"), A_1.n("cc23")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("054f7d93-85fd-4dbf-8587-b96af988c9d5"), A_1.n("cc23")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("6aef21c1-f021-47fb-89be-d09002ee7f84"), A_1.n("cc23")).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("063de411-a6eb-40de-b67e-9b369f6c7c23"), A_1.n("cc23")).ao() as c5x;
			c5x c5x6 = new ar7(new Guid("d36c8661-fa4e-41d6-b008-4bb12d100892"), A_1.n("cc23")).ao() as c5x;
			c5x c5x7 = new ar7(new Guid("fa2f233e-d1ff-492c-ae3c-5031c1d588ea"), A_1.n("cc23")).ao() as c5x;
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b.X = 5;
			}
			if (c5x3 != null && c5x3.o.b != null)
			{
				c5x3.o.b.b.X = 6;
			}
			if (c5x4 != null && c5x4.o.b != null)
			{
				c5x4.o.b.b.X = 7;
			}
			if (c5x5 != null && c5x5.o.b != null)
			{
				c5x5.o.b.b.X = 5;
			}
			if (c5x6 != null && c5x6.o.b != null)
			{
				c5x6.o.b.b.X = 8;
			}
			if (c5x7 != null && c5x7.o.b != null)
			{
				c5x7.o.b.b.X = 2;
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
