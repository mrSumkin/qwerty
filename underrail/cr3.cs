using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200033A RID: 826
[apc("cc_duff")]
public sealed class cr3 : esk
{
	// Token: 0x0600176D RID: 5997 RVA: 0x00076654 File Offset: 0x00074854
	public cr3()
	{
		this.c = new ej0(new Action<ej0>(cr3.a.a.a));
		this.c.a = this.j;
		this.j.a.Insert(0, new arr(this.c, new Func<e1k, bool>(cr3.a.a.b)));
		this.b = new ej0(new Action<ej0>(cr3.a.a.b));
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(cr3.a.a.a));
		array[1] = new arr(this.c.a, null);
		this.a = new fh(array);
		this.b.a = this.c;
		this.c.a = this.a;
	}

	// Token: 0x04000DF4 RID: 3572
	private new fh a;

	// Token: 0x04000DF5 RID: 3573
	private new ej0 b;

	// Token: 0x04000DF6 RID: 3574
	private new ej0 c;

	// Token: 0x0200033B RID: 827
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x000767A0 File Offset: 0x000749A0
		internal void a(ej0 A_0)
		{
			eaq eaq = new eaq();
			eaq.b(asp.a);
			eaq.a(asp.dt);
			eaq.a(global::h.a);
			eaq.a(true);
			eaq.ym(null, null, null);
			new cct("Я сказал, без пушек. Взять его, девочки!", true, null, bvl.c).ym(null, A_0.b().g().a8(), null);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0007680C File Offset: 0x00074A0C
		internal bool b(e1k A_0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			cky cky = serviceOrThrow.aqu().ac().abu(asp.dt, asp.a);
			if (cky != null && cky.a != global::h.a && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_fistfightStarted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_forfeitFistfight", new bool?(false)).Value;
				if (value && !value2)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					amc amc = new bzv(A_0.c().y6()).g();
					if (amc != null && amc == c5x.h.b)
					{
						if (c5x.h.b.aa().Gear.h().Item != null || (c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item != null && !euf.o(c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item)) || (c5x.h.b.aa().Gear.j()[WeaponKey.Secondary].Item != null && !euf.o(c5x.h.b.aa().Gear.j()[WeaponKey.Secondary].Item)))
						{
							return true;
						}
						ItemSlot<coh>[] array = c5x.h.b.aa().Gear.d();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].Item != null)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00076A3C File Offset: 0x00074C3C
		internal void b(ej0 A_0)
		{
			A_0.b().g().aa().PersonalAttitudes.Clear();
			new bzv(A_0.b().c().y6()).e();
			eaq eaq = new eaq();
			eaq.b(asp.a);
			eaq.a(asp.d2);
			eaq.a(global::h.b);
			eaq.a(true);
			eaq.ym(null, null, null);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_cc_duff_forfeitFistfight"] = true;
				if (serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().PersonalAttitudes.Remove(asp.d2);
					eaq eaq2 = new eaq();
					eaq2.b(asp.a);
					eaq2.a(asp.d2);
					eaq2.a(global::h.b);
					eaq2.a(true);
					eaq2.ym(null, null, null);
					new cct("Ладно, ладно! Я сдаюсь!", true, null, bvl.c).ym(null, A_0.b().g().a8(), null);
					A_0.b().g().aa().FactionId = asp.dt;
					bpo.GetServiceOrThrow<d02>().ahs(true, false);
				}
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00076B8C File Offset: 0x00074D8C
		internal bool a(e1k A_0)
		{
			if ((double)A_0.g().aa().Defense.q().zo() <= (double)A_0.g().aa().Defense.q().zm() * 0.25)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					cky cky = serviceOrThrow.aqu().ac().abu(asp.dt, asp.a);
					if (cky != null && cky.a != global::h.a)
					{
						bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_fistfightStarted", new bool?(false)).Value;
						bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_forfeitFistfight", new bool?(false)).Value;
						if (value && !value2)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04000DF7 RID: 3575
		public static readonly cr3.a a = new cr3.a();

		// Token: 0x04000DF8 RID: 3576
		public static Action<ej0> b;

		// Token: 0x04000DF9 RID: 3577
		public static Func<e1k, bool> c;

		// Token: 0x04000DFA RID: 3578
		public static Action<ej0> d;

		// Token: 0x04000DFB RID: 3579
		public static Func<e1k, bool> e;
	}
}
