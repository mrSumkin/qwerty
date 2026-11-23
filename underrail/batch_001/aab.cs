using System;
using System.Diagnostics;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x020021BB RID: 8635
[bmq("1.0.1.11_OddityPlacements", "1.0.1.11", "*", false)]
public sealed class aab : fg
{
	// Token: 0x0600C9CC RID: 51660 RVA: 0x00476954 File Offset: 0x00474B54
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			this.a(A_1, "dc-la1", "dc-la1", "f1201f8b-61f4-4d66-8135-e27206b2efb2", "BlackEye");
			this.a(A_1, "dc-mut2", "dc-mut2", "043315ec-706d-4f5a-ba42-497dd10ba673", "BlackEye");
			this.a(A_1, "jy8", "jy8", "c5dfc096-644b-4bf2-bb05-2c705e95ee56", "LoadedDice");
			this.a(A_1, "up3x", "up3x", "cd291579-f64b-452f-9343-13d6548ee5e5", "TrainLog");
			this.a(A_1, "up-cc", "up-cc", "b7a484e0-bf80-4fd3-9796-a9e5ae677969", "TrainLog");
			this.a(A_1, "cc-rtun", "cc-rtun", "c3b5462d-e269-431d-b3b7-d7b697de6b4e", "TrainDriverManual");
			this.a(A_1, "up8", "up8", "bd136f29-4ce1-4ab7-b70e-9dd659e23c37", "TrainDriverManual");
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x0600C9CD RID: 51661 RVA: 0x00476A48 File Offset: 0x00474C48
	private void a(c1a A_0, string A_1, string A_2, string A_3, string A_4)
	{
		if (A_0 != null && !string.IsNullOrEmpty(A_0.y8()) && string.Equals(A_0.y8(), A_1, StringComparison.OrdinalIgnoreCase))
		{
			aud aud = A_0.n(A_2);
			if (aud != null)
			{
				LibraryItemDefinitionProvider<x2> libraryItemDefinitionProvider = new LibraryItemDefinitionProvider<x2>("Oddities\\" + A_4);
				if (libraryItemDefinitionProvider.wl() != null)
				{
					d48 a_ = new d48(libraryItemDefinitionProvider);
					EntityAspectReference<c7j, bim> entityAspectReference = new EntityAspectReference<c7j, bim>(aud, new Guid(A_3));
					if (entityAspectReference.ao() != null)
					{
						entityAspectReference.ao().ItemContainer.z3(a_, true);
						return;
					}
					EntityAspectReference<amc, amc> entityAspectReference2 = new EntityAspectReference<amc, amc>(aud, new Guid(A_3));
					if (entityAspectReference2.ao() != null)
					{
						entityAspectReference2.ao().aa().Bag.z3(a_, true);
						return;
					}
				}
			}
		}
	}
}
