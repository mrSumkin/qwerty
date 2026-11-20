using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000F22 RID: 3874
[e79("Xpbl_Pir_GoToCaptainAndAbandonJet")]
public sealed class as4 : dgy
{
	// Token: 0x06004EDF RID: 20191 RVA: 0x00237148 File Offset: 0x00235348
	public as4()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			as4.a a = new as4.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_g3", "player_abandonJet"), false, new bool?(false), 0, null, false, false, false)
				});
				base.a(new btm[]
				{
					new ace(new an9())
					{
						InitiatorRef = new ar7(aju.a, new Guid("0c191f1a-d6df-40a0-b764-327a3c05a595"), new Guid("1e5bec4e-078d-43a9-8c30-ef099898a952"), bl1.a)
					}
				});
				btm[] array2 = new btm[1];
				array2[0] = new dva(null, new Func<e6d, bool>(as4.b.a.a), null, null, null);
				base.a(array2);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_razor_leadToJoin", new bool?(false)).Value)
				{
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_g2_InnerShip", "player_meeting"), false, new bool?(false), 0, null, false, false, false)
					});
				}
				else
				{
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_g2_InnerShip", "player_darkness"), false, new bool?(false), 0, null, false, false, false)
					});
					btm[] array3 = new btm[1];
					array3[0] = new dva(null, new Func<e6d, bool>(as4.b.a.b), null, null, null);
					base.a(array3);
				}
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				btm[] array4 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
				array4[num2] = c8s;
				base.a(array4);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_razor_leadToJoin", new bool?(false)).Value)
				{
					btm[] array5 = new btm[1];
					int num3 = 0;
					d92 d = new d92();
					d.a("events\\xpbl\\pir_meetingCaptain");
					d.b(new ar7(new Guid("9a0aad9c-0486-431c-8bc4-93479f51621d"), new Guid("979caca0-9579-4568-b316-bd59413f2f40"), new Guid("b449677e-bc41-4912-851b-740e352e1630"), bl1.a));
					d.a(new ar7(a.a.qe(), new Guid("979caca0-9579-4568-b316-bd59413f2f40"), new Guid("b449677e-bc41-4912-851b-740e352e1630"), bl1.a));
					array5[num3] = d;
					base.a(array5);
				}
				else
				{
					btm[] array6 = new btm[1];
					int num4 = 0;
					d92 d2 = new d92();
					d2.a("events\\xpbl\\pir_meetingCaptain");
					d2.b(new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), new Guid("4ce1b9e0-7a2d-4a1a-b91a-f1bd9f733543"), new Guid("b449677e-bc41-4912-851b-740e352e1630"), bl1.a));
					d2.a(new ar7(a.a.qe(), new Guid("4ce1b9e0-7a2d-4a1a-b91a-f1bd9f733543"), new Guid("b449677e-bc41-4912-851b-740e352e1630"), bl1.a));
					array6[num4] = d2;
					base.a(array6);
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F23 RID: 3875
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004EE2 RID: 20194 RVA: 0x00237580 File Offset: 0x00235780
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(aju.a, new Guid("0c191f1a-d6df-40a0-b764-327a3c05a595"), new Guid("1e5bec4e-078d-43a9-8c30-ef099898a952"), bl1.a).ao() as c5x;
			if (c5x != null)
			{
				ak1 ak = c5x.Area.b((int)c5x.Location.X, (int)c5x.Location.Y);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2 != null && c5x2.GetAspect<bim>() is wv)
						{
							c5x2.b("playersJetTakenByPirates");
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x0023765C File Offset: 0x0023585C
		internal bool b(e6d A_0)
		{
			c5x c5x = new ar7(aju.a, new Guid("979caca0-9579-4568-b316-bd59413f2f40"), new Guid("b449677e-bc41-4912-851b-740e352e1630"), bl1.a).ao() as c5x;
			if (c5x != null)
			{
				c5x.ae = new float?(0f);
			}
			return true;
		}

		// Token: 0x04002050 RID: 8272
		public static readonly as4.b a = new as4.b();

		// Token: 0x04002051 RID: 8273
		public static Func<e6d, bool> b;

		// Token: 0x04002052 RID: 8274
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000F24 RID: 3876
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EE5 RID: 20197 RVA: 0x002376BC File Offset: 0x002358BC
		internal bool a(e6d A_0)
		{
			if (this.a.h.b != null)
			{
				if (this.a.h.b.aa().Offense.u() != null)
				{
					this.a.h.b.aa().Bag.z3(this.a.h.b.aa().Gear.j()[WeaponKey.Primary].Item, true);
					this.a.h.b.aa().Gear.j()[WeaponKey.Primary].a(null, true);
				}
				if (this.a.h.b.aa().Offense.q() != null)
				{
					this.a.h.b.aa().Bag.z3(this.a.h.b.aa().Gear.j()[WeaponKey.Secondary].Item, true);
					this.a.h.b.aa().Gear.j()[WeaponKey.Secondary].a(null, true);
				}
			}
			return true;
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00237818 File Offset: 0x00235A18
		internal bool b(e6d A_0)
		{
			if (this.a.h.b != null)
			{
				if (this.a.h.b.aa().Offense.u() != null)
				{
					this.a.h.b.aa().Bag.z3(this.a.h.b.aa().Gear.j()[WeaponKey.Primary].Item, true);
					this.a.h.b.aa().Gear.j()[WeaponKey.Primary].a(null, true);
				}
				if (this.a.h.b.aa().Offense.q() != null)
				{
					this.a.h.b.aa().Bag.z3(this.a.h.b.aa().Gear.j()[WeaponKey.Secondary].Item, true);
					this.a.h.b.aa().Gear.j()[WeaponKey.Secondary].a(null, true);
				}
			}
			return true;
		}

		// Token: 0x04002053 RID: 8275
		public c5x a;
	}
}
