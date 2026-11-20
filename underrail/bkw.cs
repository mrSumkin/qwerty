using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000EAD RID: 3757
[e79("Gms_VaultOpenning")]
public sealed class bkw : dgy
{
	// Token: 0x06004D9C RID: 19868 RVA: 0x00226A18 File Offset: 0x00224C18
	public bkw()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bkw.b b = new bkw.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null && b.a.Zone != null)
			{
				bkw.a a = new bkw.a();
				a.c = b;
				EntityAspectReference<bim, bim> entityAspectReference = new EntityAspectReference<bim, bim>(a.c.a.Area, new Guid("c53c533c-2d83-41c8-9785-e4422f28f3b5"));
				if (entityAspectReference.ao() != null)
				{
					entityAspectReference.ao().g(true);
				}
				c5x c5x = new ar7(new Guid("aa359bf3-88d5-4feb-9d69-eba3e50925d8"), a.c.a.Area).ao() as c5x;
				a.b = (new ar7(new Guid("4ac85867-ad45-4d94-8659-108e3b45649c"), a.c.a.Area).ao() as c5x);
				a.a = (new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), a.c.a.Area).ao() as c5x);
				coh coh = Enumerable.FirstOrDefault<coh>(a.c.a.h.b.aa().Bag.b("key_gms_sealedDoor"));
				if (coh != null)
				{
					a.c.a.h.b.aa().Bag.z5(coh);
					if (a.a != null)
					{
						a.a.h.b.aa().Bag.z3(coh, true);
					}
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4(a.c.a.Area.y8(), a.c.a.Location));
				kw.a(true);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Ладно, открывай.");
				array4[num4] = new ace(egx)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (c5x != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.OperateShort);
					bb.a(cux.a);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(c5x));
					bb.b(1);
					array5[num5] = bb;
					base.a(array5);
				}
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx2 = new egx();
				egx2.a("Срань господня...");
				array6[num6] = new ace(egx2)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4(a.c.a.Area.y8(), new Vector3(20f, 3f, 0f)));
				array7[num7] = kw2;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				egx egx3 = new egx();
				egx3.a("Здесь гнездо могильщиков.");
				array8[num8] = new ace(egx3)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				egx egx4 = new egx();
				egx4.a("Закрывай!");
				array9[num9] = new ace(egx4)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (c5x != null)
				{
					btm[] array10 = new btm[1];
					int num10 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.OperateShort);
					bb2.a(cux.a);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(c5x));
					bb2.b(1);
					array10[num10] = bb2;
					base.a(array10);
				}
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c.b), null, null, null)
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				kw kw3 = new kw();
				kw3.a(new bt4(a.c.a.Area.y8(), a.c.a.Location));
				array11[num11] = kw3;
				base.a(array11);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.d), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000EAE RID: 3758
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004D9E RID: 19870 RVA: 0x0022710C File Offset: 0x0022530C
		internal bool a(e6d A_0)
		{
			b6r b6r = new b6r();
			b6r.b(this.a.Area.y8());
			b6r.b(new Guid("c6d0ca09-2f1d-4e4a-ad15-35268180a2d5"));
			b6r.a(new Guid("75d277cb-7c7b-40f8-9d76-8e7ce7be0d91"));
			b6r.a(bbo.b);
			b6r.ym(this.a, null, null);
			edk edk = new edk();
			edk.b().Add("vault");
			edk.ym(this.a, this.a, null);
			return true;
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x00227190 File Offset: 0x00225390
		internal bool b(e6d A_0)
		{
			b6r b6r = new b6r();
			b6r.b(this.a.Area.y8());
			b6r.b(new Guid("c6d0ca09-2f1d-4e4a-ad15-35268180a2d5"));
			b6r.a(new Guid("75d277cb-7c7b-40f8-9d76-8e7ce7be0d91"));
			b6r.a(bbo.c);
			b6r.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001FBD RID: 8125
		public c5x a;
	}

	// Token: 0x02000EAF RID: 3759
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DA1 RID: 19873 RVA: 0x002271FC File Offset: 0x002253FC
		internal bool c(e6d A_0)
		{
			csd csd = this.c.a.Zone.g("vault1");
			csd csd2 = this.c.a.Zone.g("vault2");
			csd csd3 = this.c.a.Zone.g("vault3");
			if (csd3 != null)
			{
				this.c.a.Location = csd3.Location;
				this.c.a.VisualDirection = csd3.Direction;
				this.c.a.ah();
			}
			if (csd2 != null && this.a != null)
			{
				this.a.Location = csd2.Location;
				this.a.VisualDirection = csd2.Direction;
				this.a.ah();
			}
			if (csd != null && this.b != null)
			{
				this.b.Location = csd.Location;
				this.b.VisualDirection = csd.Direction;
				this.b.ah();
			}
			return true;
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x0022731C File Offset: 0x0022551C
		internal bool b(e6d A_0)
		{
			this.c.a.h.b.ap = new CharacterState?(CharacterState.Attack1);
			this.c.a.h.b.aq = new int?(0);
			if (this.a != null && this.a.h.b != null)
			{
				this.a.h.b.ap = new CharacterState?(CharacterState.Attack1);
				this.a.h.b.aq = new int?(0);
			}
			if (this.b != null && this.b.h.b != null)
			{
				this.b.h.b.ap = new CharacterState?(CharacterState.Attack1);
				this.b.h.b.aq = new int?(0);
			}
			return true;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00227418 File Offset: 0x00225618
		internal bool a(e6d A_0)
		{
			this.c.a.h.b.ap = null;
			this.c.a.h.b.aq = null;
			if (this.a != null && this.a.h.b != null)
			{
				this.a.h.b.ap = null;
				this.a.h.b.aq = null;
			}
			if (this.b != null && this.b.h.b != null)
			{
				this.b.h.b.ap = null;
				this.b.h.b.aq = null;
			}
			return true;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00227514 File Offset: 0x00225714
		internal bool d(e6d A_0)
		{
			this.c.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001FBE RID: 8126
		public c5x a;

		// Token: 0x04001FBF RID: 8127
		public c5x b;

		// Token: 0x04001FC0 RID: 8128
		public bkw.b c;
	}
}
