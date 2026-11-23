using System;
using System.Collections.Generic;
using System.Diagnostics;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02002122 RID: 8482
[bmq("Lu_cBlock_PraetorianArmorFix", "1.1.2.4", "*", false)]
public sealed class avl : fg
{
	// Token: 0x0600C890 RID: 51344 RVA: 0x0046B904 File Offset: 0x00469B04
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					amc aspect = c5x.GetAspect<amc>();
					dqv aspect2 = c5x.GetAspect<dqv>();
					if (aspect != null && aspect2 == null)
					{
						Random random = new Random(c5x.qe().GetHashCode() + c5x.Area.qe().GetHashCode());
						a6p aspect3 = c5x.GetAspect<a6p>();
						if (aspect3 != null && !string.IsNullOrEmpty(aspect3.b()) && aspect3.b().StartsWith("Locale\\Creatures\\GenericHumans\\Praetorian", StringComparison.OrdinalIgnoreCase))
						{
							if (aspect3.b().Equals("Locale\\Creatures\\GenericHumans\\PraetorianGunner", StringComparison.OrdinalIgnoreCase))
							{
								LibraryItemDefinitionProvider<c43> libraryItemDefinitionProvider;
								string text;
								if (aspect3.d() == null || (!ceo.a(new HashSet<string>(aspect3.d()), "model") && random.NextDouble() < 0.5))
								{
									libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<c43>("armor\\PraetorianHeavyArmorTabard");
									text = "praet";
								}
								else
								{
									libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<c43>("armor\\PraetorianHeavyArmorCaped");
									text = "praec";
								}
								if (libraryItemDefinitionProvider != null && libraryItemDefinitionProvider.wl() != null)
								{
									c8d a_ = new c8d(libraryItemDefinitionProvider);
									aspect.aa().Gear.l().a(a_, true);
								}
								LibraryItemDefinitionProvider<bqu> libraryItemDefinitionProvider2 = ez2.CreateDefinitonProvider<bqu>("armor\\PraetorianHeavyHelmet");
								if (libraryItemDefinitionProvider2 != null && libraryItemDefinitionProvider2.wl() != null)
								{
									k7 a_2 = new k7(libraryItemDefinitionProvider2);
									aspect.aa().Gear.g().a(a_2, true);
								}
								if (aspect.aa().Gender == Gender.Female)
								{
									text += "_f";
								}
								aspect.a(text);
							}
							else if (aspect3.b().Equals("Locale\\Creatures\\GenericHumans\\PraetorianBomber", StringComparison.OrdinalIgnoreCase) || aspect3.b().Equals("Locale\\Creatures\\GenericHumans\\PraetorianSniper", StringComparison.OrdinalIgnoreCase))
							{
								LibraryItemDefinitionProvider<c43> libraryItemDefinitionProvider3 = ez2.CreateDefinitonProvider<c43>("armor\\PraetorianMediumArmor");
								if (libraryItemDefinitionProvider3 != null && libraryItemDefinitionProvider3.wl() != null)
								{
									c8d a_3 = new c8d(libraryItemDefinitionProvider3);
									aspect.aa().Gear.l().a(a_3, true);
								}
								LibraryItemDefinitionProvider<bqu> libraryItemDefinitionProvider4 = ez2.CreateDefinitonProvider<bqu>("armor\\gasMask");
								if (libraryItemDefinitionProvider4 != null && libraryItemDefinitionProvider4.wl() != null)
								{
									k7 a_4 = new k7(libraryItemDefinitionProvider4);
									aspect.aa().Gear.g().a(a_4, true);
								}
								aspect.a((aspect.aa().Gender == Gender.Female) ? "praem_f" : "praem");
							}
						}
					}
				}
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
