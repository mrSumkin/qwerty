using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001912 RID: 6418
public class eub : bd3
{
	// Token: 0x0600884E RID: 34894 RVA: 0x00386868 File Offset: 0x00384A68
	static eub()
	{
		eub.a();
	}

	// Token: 0x06008850 RID: 34896 RVA: 0x0038687C File Offset: 0x00384A7C
	public List<bj8> bz()
	{
		List<bj8> list = new List<bj8>();
		foreach (object obj in Enum.GetValues(typeof(AmmoType)))
		{
			AmmoType ammoType = (AmmoType)obj;
			if (ammoType >= AmmoType.ShotgunShell)
			{
				break;
			}
			if (ammoType != AmmoType.None)
			{
				int num = (int)ammoType;
				int num2 = num % 100 - 1;
				if (num2 >= 0)
				{
					int y = num / 100 - 1;
					bj8 bj = new bj8();
					bj.a("Ammo." + ammoType.ToString());
					bj.a().Add(new d8h("Ammo", new Point(num2, y), 1f));
					list.Add(bj);
				}
			}
		}
		return list;
	}

	// Token: 0x06008851 RID: 34897 RVA: 0x00386970 File Offset: 0x00384B70
	public static dh0 h(AmmoType A_0)
	{
		dh0 result;
		eub.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06008852 RID: 34898 RVA: 0x0038698C File Offset: 0x00384B8C
	private static void a()
	{
		eub.a = new Dictionary<AmmoType, dh0>();
		eub.a[AmmoType.Caliber_5] = new dh0("5мм патроны");
		eub.a[AmmoType.Caliber_5_Std] = new dh0("5мм патроны (стандартные)");
		eub.a[AmmoType.Caliber_5_W2C] = new dh0("5мм патроны (бронебойные)", Color.Green);
		eub.a[AmmoType.Caliber_5_JHP] = new dh0("5мм патроны (экспансивные)", Color.DarkRed);
		eub.a[AmmoType.Caliber_5_Shock] = new dh0("5мм патроны (электрошоковые)", new Color(20, 121, 222));
		eub.a[AmmoType.Caliber_762] = new dh0("7,62мм патроны");
		eub.a[AmmoType.Caliber_762_Std] = new dh0("7,62мм патроны (стандартные)");
		eub.a[AmmoType.Caliber_762_W2C] = new dh0("7,62мм патроны (бронебойные)", Color.Green);
		eub.a[AmmoType.Caliber_762_JHP] = new dh0("7,62мм патроны (экспансивные)", Color.DarkRed);
		eub.a[AmmoType.Caliber_762_MS] = new dh0("7,62мм патроны (микрошрапнельные)", new Color(164, 162, 89));
		eub.a[AmmoType.Caliber_9] = new dh0("9мм патроны");
		eub.a[AmmoType.Caliber_9_Std] = new dh0("9мм патроны (стандартные)");
		eub.a[AmmoType.Caliber_9_W2C] = new dh0("9мм патроны (бронебойные)", Color.Green);
		eub.a[AmmoType.Caliber_9_JHP] = new dh0("9мм патроны (экспансивные)", Color.DarkRed);
		eub.a[AmmoType.Caliber_9_Acid] = new dh0("9мм патроны (кислотные)", new Color(38, 194, 8));
		eub.a[AmmoType.Caliber_44] = new dh0(".44 патроны");
		eub.a[AmmoType.Caliber_44_Std] = new dh0(".44 патроны (стандартные)");
		eub.a[AmmoType.Caliber_44_W2C] = new dh0(".44 патроны (бронебойные)", Color.Green);
		eub.a[AmmoType.Caliber_44_JHP] = new dh0(".44 патроны (экспансивные)", Color.DarkRed);
		eub.a[AmmoType.Caliber_44_Exp] = new dh0(".44 патроны (разрывные)", new Color(183, 139, 58));
		eub.a[AmmoType.Caliber_86] = new dh0("8,6мм патроны");
		eub.a[AmmoType.Caliber_86_Std] = new dh0("8,6мм патроны (стандартные)");
		eub.a[AmmoType.Caliber_86_W2C] = new dh0("8,6мм патроны (бронебойные)", Color.Green);
		eub.a[AmmoType.Caliber_86_JHP] = new dh0("8,6мм патроны (экспансивные)", Color.DarkRed);
		eub.a[AmmoType.Caliber_86_Inc] = new dh0("8,6мм патроны (зажигательные)", Color.OrangeRed);
		eub.a[AmmoType.Caliber_127] = new dh0("12,7мм патроны");
		eub.a[AmmoType.Caliber_127_Std] = new dh0("12,7мм патроны (стандартные)");
		eub.a[AmmoType.Caliber_127_W2C] = new dh0("12,7мм патроны (бронебойные)", Color.Green);
		eub.a[AmmoType.Caliber_127_JHP] = new dh0("12,7мм патроны (экспансивные)", Color.DarkRed);
		eub.a[AmmoType.Caliber_127_Cnt] = new dh0("12,7мм патроны (заражённые)", new Color(169, 156, 70));
		eub.a[AmmoType.ShotgunShell] = new dh0("патрон дробовика", Color.Orange);
		eub.a[AmmoType.ShotgunShell_6] = new dh0("патрон с 6 дробинами", new Color(168, 23, 23));
		eub.a[AmmoType.ShotgunShell_12] = new dh0("патрон с 12 дробинами", new Color(38, 102, 102));
		eub.a[AmmoType.ShotgunShell_20] = new dh0("патрон с 20 дробинами", new Color(159, 159, 47));
		eub.a[AmmoType.ShotgunShell_3] = new dh0("патрон с 3 вольфрамовыми дробинами", new Color(75, 93, 13));
		eub.a[AmmoType.Grenade_25] = new dh0("25мм граната", Color.Orange);
		eub.a[AmmoType.Grenade_25_Frag] = new dh0("25мм осколочная граната", new Color(100, 105, 75));
		eub.a[AmmoType.Grenade_25_He] = new dh0("25мм фугасная граната", new Color(140, 130, 130));
		eub.a[AmmoType.Grenade_25_Concussive] = new dh0("25мм ошеломляющая граната", new Color(65, 115, 170));
		eub.a[AmmoType.Grenade_25_Incendiary] = new dh0("25мм зажигательная граната", new Color(100, 60, 65));
		eub.a[AmmoType.Grenade_40] = new dh0("40мм граната", Color.Orange);
		eub.a[AmmoType.Grenade_40_Frag] = new dh0("40мм осколочная граната", new Color(85, 135, 100));
		eub.a[AmmoType.Grenade_40_He] = new dh0("40мм фугасная граната", new Color(150, 165, 175));
		eub.a[AmmoType.Grenade_40_Thermobaric] = new dh0("40мм термобарическая граната", new Color(177, 155, 120));
		eub.a[AmmoType.Grenade_40_Cluster] = new dh0("40мм кассетная граната", new Color(200, 180, 65));
		eub.a[AmmoType.Rocket_84] = new dh0("84мм ракета", Color.Orange);
		eub.a[AmmoType.Rocket_84_He] = new dh0("84мм фугасная ракета", new Color(170, 60, 46));
		eub.a[AmmoType.Rocket_84_Wp] = new dh0("84мм ракета с белым фосфором", new Color(155, 155, 155));
		eub.a[AmmoType.Rocket_84_Kin] = new dh0("84мм кинетическая ракета", new Color(153, 135, 45));
		eub.a[AmmoType.Rocket_84_Cs] = new dh0("84мм ракета сотрясатель пещер", new Color(88, 100, 115));
		eub.a[AmmoType.Rocket_40] = new dh0("40мм ракета", Color.Orange);
		eub.a[AmmoType.Rocket_40_Tandem] = new dh0("40мм ракета с тандемным зарядом", new Color(140, 100, 25));
		eub.a[AmmoType.Rocket_66] = new dh0("66мм ракета", Color.Orange);
		eub.a[AmmoType.Rocket_66_Incendiary] = new dh0("66мм зажигательная ракета", Color.OrangeRed);
		eub.a[AmmoType.Vial_Acid] = new dh0("колба с кислотой", new Color(0, 255, 0));
		eub.a[AmmoType.Vial_Acid_Regular] = new dh0("колба с кислотой", new Color(0, 255, 0));
		eub.a[AmmoType.Vial_Acid_Corrosive] = new dh0("колба с едкой кислотой", new Color(219, 70, 237));
		eub.a[AmmoType.Vial_Acid_Rusting] = new dh0("колба с ржа-кислотой", new Color(209, 203, 91));
		eub.a[AmmoType.Vial_Cryogel] = new dh0("колба с криогелем", new Color(50, 255, 255));
		eub.a[AmmoType.Vial_Incendiary] = new dh0("колба с зажигательной жидкостью", new Color(255, 73, 0));
		eub.b = new Dictionary<AmmoType, double>();
		eub.b[AmmoType.ShotgunShell] = 0.1;
		eub.b[AmmoType.ShotgunShell_6] = 0.15;
		eub.b[AmmoType.ShotgunShell_12] = 0.09;
		eub.b[AmmoType.ShotgunShell_20] = 0.06;
		eub.b[AmmoType.ShotgunShell_3] = 0.25;
		eub.c = new Dictionary<AmmoType, int>();
		eub.c[AmmoType.ShotgunShell] = 6;
		eub.c[AmmoType.ShotgunShell_6] = 6;
		eub.c[AmmoType.ShotgunShell_12] = 12;
		eub.c[AmmoType.ShotgunShell_20] = 20;
		eub.c[AmmoType.ShotgunShell_3] = 3;
	}

	// Token: 0x06008853 RID: 34899 RVA: 0x00387258 File Offset: 0x00385458
	public static bool d(efk A_0)
	{
		if (A_0 != null)
		{
			foreach (ItemSlot<coh> itemSlot in A_0.Gear.d())
			{
				if (itemSlot.Item != null)
				{
					acz acz = itemSlot.Item as acz;
					if (acz != null && acz.Definition.a2() != null && acz.Definition.a2().Count > 0)
					{
						c3n c3n = acz.Definition.a2()[0].Value;
						if (c3n != null && c3n is eyv)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06008854 RID: 34900 RVA: 0x00387304 File Offset: 0x00385504
	public static AmmoType g(AmmoType A_0)
	{
		if (A_0 == AmmoType.None || A_0 == AmmoType.Energy || A_0 == AmmoType.Bolts)
		{
			return A_0;
		}
		int num = (int)(A_0 / AmmoType.Caliber_5 * AmmoType.Caliber_5);
		AmmoType result;
		if (Enum.IsDefined(typeof(AmmoType), num) && Enum.TryParse<AmmoType>(num.ToString(), out result))
		{
			return result;
		}
		return AmmoType.None;
	}

	// Token: 0x06008855 RID: 34901 RVA: 0x00387368 File Offset: 0x00385568
	public static Dictionary<AmmoType, int> d(cd1 A_0)
	{
		Dictionary<AmmoType, int> dictionary = new Dictionary<AmmoType, int>();
		foreach (AmmoType key in A_0.LoadedAmmo)
		{
			int num;
			dictionary.TryGetValue(key, out num);
			dictionary[key] = num + 1;
		}
		return dictionary;
	}

	// Token: 0x06008856 RID: 34902 RVA: 0x003873D8 File Offset: 0x003855D8
	public static AmmoType[] a(AmmoType A_0, int A_1)
	{
		AmmoType[] array = new AmmoType[A_1];
		for (int i = 0; i < A_1; i++)
		{
			array[i] = A_0;
		}
		return array;
	}

	// Token: 0x06008857 RID: 34903 RVA: 0x00387400 File Offset: 0x00385600
	public static int c(efk A_0)
	{
		if (A_0 != null)
		{
			int num = 0;
			foreach (coh coh in A_0.Bag.b("Ammo.Bolt"))
			{
				num += coh.Stacks;
			}
			return num;
		}
		return 0;
	}

	// Token: 0x06008858 RID: 34904 RVA: 0x00387470 File Offset: 0x00385670
	public static bool b(efk A_0)
	{
		if (A_0 != null)
		{
			coh coh = Enumerable.FirstOrDefault<coh>(A_0.Bag.b("Ammo.Bolt"));
			if (coh != null)
			{
				if (coh.Stacks > 1)
				{
					coh coh2 = coh;
					int num = coh2.Stacks;
					coh2.Stacks = num - 1;
				}
				else
				{
					A_0.Bag.z5(coh);
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008859 RID: 34905 RVA: 0x003874D0 File Offset: 0x003856D0
	public static bool b(efk A_0, cd1 A_1)
	{
		if (A_1.TypedDefinition.ak() == AmmoType.Bolts)
		{
			return Enumerable.FirstOrDefault<coh>(A_0.Bag.b("Ammo.Bolt")) != null;
		}
		if (A_1.TypedDefinition.ak() == AmmoType.Energy)
		{
			return A_1.Battery >= A_1.TypedDefinition.k();
		}
		return A_1.TypedDefinition.ak() == AmmoType.None || A_1.TypedDefinition.ak() >= AmmoType.Sledgehammer || A_1.LoadedAmmo.Count > 0;
	}

	// Token: 0x0600885A RID: 34906 RVA: 0x0038756C File Offset: 0x0038576C
	public static bool a(efk A_0, bke A_1)
	{
		eub.b b = new eub.b();
		b.a = A_1;
		if (b.a.ak() == AmmoType.None)
		{
			return true;
		}
		if (b.a.ak() == AmmoType.Bolts)
		{
			return Enumerable.FirstOrDefault<coh>(A_0.Bag.b("Ammo.Bolt")) != null;
		}
		if (b.a.ak() == AmmoType.Energy)
		{
			return Enumerable.Any<coh>(A_0.Bag.z2(), new Func<coh, bool>(eub.a.a.a));
		}
		return Enumerable.Any<dng>(Enumerable.OfType<dng>(A_0.Bag.z2()), new Func<dng, bool>(b.a));
	}

	// Token: 0x0600885B RID: 34907 RVA: 0x00387630 File Offset: 0x00385830
	public static bool a(efk A_0)
	{
		return Enumerable.Any<coh>(A_0.Bag.z2(), new Func<coh, bool>(eub.a.a.b));
	}

	// Token: 0x0600885C RID: 34908 RVA: 0x00387670 File Offset: 0x00385870
	public static bool a(efk A_0, cd1 A_1)
	{
		bke bke = A_1.TypedDefinition;
		if (bke == null)
		{
			return false;
		}
		if (bke.ak() == AmmoType.Energy)
		{
			if (A_1.Battery >= A_1.TypedDefinition.k())
			{
				A_1.Battery -= A_1.TypedDefinition.k();
				return true;
			}
			return false;
		}
		else
		{
			if (bke.ak() == AmmoType.Bolts)
			{
				return eub.b(A_0);
			}
			if (bke.ak() == AmmoType.None)
			{
				return true;
			}
			if (A_1.LoadedAmmo.Count > 0)
			{
				A_1.LoadedAmmo.RemoveAt(A_1.LoadedAmmo.Count - 1);
				double num = 0.0;
				string text = null;
				if (eub.c(bke.ak()))
				{
					text = "components\\ammoCase\\xpbl\\ShotgunShell";
					num = 0.5;
				}
				else if (eub.g(bke.ak()) == AmmoType.Grenade_25 || eub.g(bke.ak()) == AmmoType.Grenade_40)
				{
					text = "components\\ammoCase\\xphw\\" + bke.ak().ToString();
					num = 0.5;
				}
				else if (eub.f(bke.ak()))
				{
					text = "components\\ammoCase\\" + bke.ak().ToString();
					num = 0.3;
				}
				if (text != null && cuo.a.NextDouble() < num && ez2.GetItemDefinition<a1k>(text, false) != null)
				{
					fv a_ = new fv(ez2.CreateDefinitonProvider<a1k>(text));
					A_0.Bag.z3(a_, true);
				}
				return true;
			}
			return false;
		}
	}

	// Token: 0x0600885D RID: 34909 RVA: 0x00387828 File Offset: 0x00385A28
	public static bool c(cd1 A_0)
	{
		return A_0 != null && A_0.TypedDefinition != null && eub.f(A_0.TypedDefinition.ak());
	}

	// Token: 0x0600885E RID: 34910 RVA: 0x00387850 File Offset: 0x00385A50
	public static bool f(AmmoType A_0)
	{
		return A_0 != AmmoType.None && (A_0 < AmmoType.Vial_Acid || A_0 / AmmoType.Caliber_5 == (AmmoType)13 || A_0 / AmmoType.Caliber_5 == (AmmoType)14 || A_0 / AmmoType.Caliber_5 == (AmmoType)15);
	}

	// Token: 0x0600885F RID: 34911 RVA: 0x00387888 File Offset: 0x00385A88
	public static bool e(AmmoType A_0)
	{
		return A_0 != AmmoType.None && A_0 < AmmoType.ShotgunShell;
	}

	// Token: 0x06008860 RID: 34912 RVA: 0x0038789C File Offset: 0x00385A9C
	public static bool d(AmmoType A_0)
	{
		return A_0 >= AmmoType.Vial_Acid && A_0 <= AmmoType.Vial_Incendiary;
	}

	// Token: 0x06008861 RID: 34913 RVA: 0x003878B8 File Offset: 0x00385AB8
	public static bool b(cd1 A_0)
	{
		return A_0.TypedDefinition != null && A_0.MaxBattery > 0;
	}

	// Token: 0x06008862 RID: 34914 RVA: 0x003878D4 File Offset: 0x00385AD4
	public static bool a(cd1 A_0)
	{
		return A_0.TypedDefinition != null && (A_0.TypedDefinition.ak() == AmmoType.None || A_0.TypedDefinition.g() || A_0.TypedDefinition.ak() >= AmmoType.Sledgehammer);
	}

	// Token: 0x06008863 RID: 34915 RVA: 0x00387928 File Offset: 0x00385B28
	public static bool c(AmmoType A_0)
	{
		return eub.g(A_0) == AmmoType.ShotgunShell;
	}

	// Token: 0x06008864 RID: 34916 RVA: 0x00387938 File Offset: 0x00385B38
	public static bool b(AmmoType A_0)
	{
		AmmoType ammoType = eub.g(A_0);
		return ammoType == AmmoType.Grenade_25 || ammoType == AmmoType.Grenade_40;
	}

	// Token: 0x06008865 RID: 34917 RVA: 0x00387964 File Offset: 0x00385B64
	public static bool a(AmmoType A_0)
	{
		AmmoType ammoType = eub.g(A_0);
		return ammoType == AmmoType.Rocket_84 || ammoType == AmmoType.Rocket_66 || ammoType == AmmoType.Rocket_40;
	}

	// Token: 0x06008866 RID: 34918 RVA: 0x00387998 File Offset: 0x00385B98
	public static string a(cd1 A_0, int A_1, bool A_2)
	{
		if (euf.i(A_0) || euf.j(A_0))
		{
			if (A_1 == 1)
			{
				return "GrenadeLauncherReloadBullet";
			}
			if (A_1 > 1)
			{
				return "GrenadeLauncherReload";
			}
			if (A_1 == 0 && A_2)
			{
				return "GrenadeLauncherUnload";
			}
		}
		if (euf.k(A_0))
		{
			if (A_1 == 1)
			{
				return "ShotgunReloadBullet";
			}
			if (A_1 > 1)
			{
				return "ShotgunReload";
			}
			if (A_1 == 0 && A_2)
			{
				return "ShotgunUnload";
			}
		}
		if (A_0.TypedDefinition.ak() > AmmoType.None && A_0.TypedDefinition.ak() < AmmoType.Energy)
		{
			if (A_1 == 1)
			{
				return "PistolReloadBullet";
			}
			if (A_1 > 1)
			{
				return "PistolReload";
			}
			if (A_1 == 0 && A_2)
			{
				return "PistolUnload";
			}
		}
		return null;
	}

	// Token: 0x04003672 RID: 13938
	private static Dictionary<AmmoType, dh0> a;

	// Token: 0x04003673 RID: 13939
	public static Dictionary<AmmoType, double> b;

	// Token: 0x04003674 RID: 13940
	public static Dictionary<AmmoType, int> c;

	// Token: 0x02001913 RID: 6419
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06008869 RID: 34921 RVA: 0x00387A84 File Offset: 0x00385C84
		internal bool a(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x00387AA0 File Offset: 0x00385CA0
		internal bool b(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x04003675 RID: 13941
		public static readonly eub.a a = new eub.a();

		// Token: 0x04003676 RID: 13942
		public static Func<coh, bool> b;

		// Token: 0x04003677 RID: 13943
		public static Func<coh, bool> c;
	}

	// Token: 0x02001914 RID: 6420
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600886C RID: 34924 RVA: 0x00387AC4 File Offset: 0x00385CC4
		internal bool a(dng A_0)
		{
			return eub.g(A_0.TypedDefinition.b()) == this.a.ak();
		}

		// Token: 0x04003678 RID: 13944
		public bke a;
	}
}
