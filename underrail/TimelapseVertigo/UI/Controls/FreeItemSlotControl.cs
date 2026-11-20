using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

namespace TimelapseVertigo.UI.Controls
{
	// Token: 0x0200004E RID: 78
	public class FreeItemSlotControl<T> : cqy, dl0 where T : coh
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00005D1C File Offset: 0x00003F1C
		public new Func<coh> a()
		{
			return this.i;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005D24 File Offset: 0x00003F24
		public new void a(Func<coh> A_0)
		{
			this.i = A_0;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005D30 File Offset: 0x00003F30
		public new euz d()
		{
			return this.h;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005D38 File Offset: 0x00003F38
		public new void a(euz A_0)
		{
			this.h = A_0;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005D44 File Offset: 0x00003F44
		public override coh x6()
		{
			return this.d.Item;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005D58 File Offset: 0x00003F58
		public override bool ah8()
		{
			return this.d.Enabled;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005D68 File Offset: 0x00003F68
		public override string x8()
		{
			return this.e;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005D70 File Offset: 0x00003F70
		public override void x9(string A_0)
		{
			this.e = A_0;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005D7C File Offset: 0x00003F7C
		public new bool b()
		{
			return this.f;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005D84 File Offset: 0x00003F84
		public new void a(bool A_0)
		{
			this.f = A_0;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005D90 File Offset: 0x00003F90
		public bool c()
		{
			return this.g;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005D98 File Offset: 0x00003F98
		public new void b(bool A_0)
		{
			this.g = A_0;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005DA4 File Offset: 0x00003FA4
		public Type ah9()
		{
			return typeof(T);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public FreeItemSlotControl(ItemSlot<T> A_0, esj A_1, esj A_2) : base(A_1, A_2)
		{
			czh.a(A_0, "itemSlot");
			this.d = A_0;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005E10 File Offset: 0x00004010
		public FreeItemSlotControl(ItemSlot<T> A_0)
		{
			czh.a(A_0, "itemSlot");
			this.d = A_0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005E68 File Offset: 0x00004068
		public override bool iq(e08 A_0)
		{
			if (!this.d.Enabled || A_0 == null)
			{
				return false;
			}
			if (!this.x7())
			{
				return false;
			}
			T t = A_0.c() as T;
			if (t != null && this.aek(t))
			{
				ebk ebk = A_0.a() as ebk;
				if (ebk != null && this.ye(ebk, t) && ebk.yg(this))
				{
					FreeItemSlotControl<T> freeItemSlotControl = A_0.a() as FreeItemSlotControl<T>;
					return freeItemSlotControl == null || freeItemSlotControl.d != this.d;
				}
			}
			return false;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005F20 File Offset: 0x00004120
		public override bool ye(ebk A_0, coh A_1)
		{
			if (base.ye(A_0, A_1))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (A_1 != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					if (base.Name == "weaponSlot")
					{
						cd1 cd = A_1 as cd1;
						if (cd != null && cd.TypedDefinition != null && serviceOrThrow.aqu().v().Gear.l().Item != null && serviceOrThrow.aqu().v().Gear.l().Item.fu() != null && serviceOrThrow.aqu().v().Gear.l().Item.fu().a() && !euf.a(serviceOrThrow.aqu().v(), cd))
						{
							return false;
						}
						if (!euf.a(serviceOrThrow.aqu().v().Vehicle, cd))
						{
							return false;
						}
					}
					else if (base.Name == "armorSuitSlot")
					{
						if (serviceOrThrow.aqu().ae() >= GameDifficulty.Hard && serviceOrThrow.aqu().v().b() != null && awq.a(serviceOrThrow.aqu().v().b()))
						{
							return false;
						}
						c8d c8d = A_1 as c8d;
						if (c8d != null && c8d.fu() != null && c8d.fu().a() && (!euf.a(serviceOrThrow.aqu().v(), serviceOrThrow.aqu().v().Gear.j()[WeaponKey.Primary].Item) || !euf.a(serviceOrThrow.aqu().v(), serviceOrThrow.aqu().v().Gear.j()[WeaponKey.Secondary].Item)))
						{
							return false;
						}
					}
				}
				if ((base.Name == "weaponSlot" || base.Name == "quickSlot") && A_0.x8() != ItemExchangeParty.PlayerGear.ToString() && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInCombat)
				{
					d4n d4n = dz6.b(serviceOrThrow.aqu().v());
					if (d4n != null)
					{
						return d4n.c >= (double)euf.h(serviceOrThrow.aqu().v());
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000061D0 File Offset: 0x000043D0
		public override coh yb(coh A_0, bool A_1 = false)
		{
			coh result = this.d.Item;
			this.d.Item = (A_0 as T);
			if (A_0 != null && (base.Name == "weaponSlot" || base.Name == "quickSlot"))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInCombat)
				{
					d4n d4n = dz6.b(serviceOrThrow.aqu().v());
					if (d4n != null)
					{
						d4n.a(euf.h(serviceOrThrow.aqu().v()), true);
						ps service = bpo.GetService<ps>();
						if (service != null)
						{
							service.alh().abl();
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000062B0 File Offset: 0x000044B0
		public override void yc(coh A_0, int A_1, int A_2)
		{
			base.yc(A_0, A_1, A_2);
			if (A_0 != null && (base.Name == "weaponSlot" || base.Name == "quickSlot") && A_2 > A_1)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInCombat)
				{
					d4n d4n = dz6.b(serviceOrThrow.aqu().v());
					if (d4n != null)
					{
						d4n.a(euf.h(serviceOrThrow.aqu().v()), true);
						ps service = bpo.GetService<ps>();
						if (service != null)
						{
							service.alh().abl();
						}
					}
				}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006378 File Offset: 0x00004578
		public override coh yd()
		{
			coh result = this.x6();
			this.d.Item = default(T);
			return result;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000063A0 File Offset: 0x000045A0
		public override bool yg(ebk A_0)
		{
			if (base.Name == "armorSuitSlot")
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().ae() >= GameDifficulty.Hard && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && awq.a(serviceOrThrow.aqu().v().b()))
				{
					return false;
				}
			}
			return A_0 != this && base.yg(A_0);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006438 File Offset: 0x00004638
		public override void iv(e6d A_0, cp9 A_1)
		{
			if (this.ah8())
			{
				wj wj = wj.a();
				if (this.x6() != null && this.x6().Definition != null && !this.x6().Definition.a9() && this.x6().MaxDurability > 0)
				{
					double num = this.x6().Durability / (double)this.x6().MaxDurability;
					Color? color = null;
					if (num < dwh.i)
					{
						color = new Color?(Color.Red);
					}
					else if (num < dwh.h)
					{
						color = new Color?(Color.Orange);
					}
					if (color != null)
					{
						Texture2D resource = A_1.a.GetResource<Texture2D>(this.d, null);
						if (resource != null)
						{
							Point point = base.at();
							if (wj.d == UiSize.Classic)
							{
								Vector2 a_ = new Vector2((float)(point.X - 8), (float)(point.Y - 8));
								A_1.b().w5(resource, a_, new Rectangle?(this.c), color.Value * 0.5f);
							}
							else
							{
								Vector2 vector = (wj.cp.b() - base.Size.b()) / 2f;
								Vector2 a_2 = new Vector2((float)((int)((float)point.X - vector.X)), (float)((int)((float)point.Y - vector.Y)));
								A_1.b().w5(resource, a_2, new Rectangle?(this.c), color.Value * 0.5f);
							}
						}
					}
				}
				T t = default(T);
				chr service = bpo.GetService<chr>();
				if (service != null && service.ax() != null)
				{
					t = (service.ax().c() as T);
				}
				else if (this.i != null)
				{
					t = (this.i() as T);
				}
				if (t != null && this.aek(t))
				{
					Texture2D texture2D = A_1.a.us(this.d, new double?((double)-1));
					if (texture2D != null)
					{
						Point point2 = base.at();
						if (wj.d == UiSize.Classic)
						{
							Vector2 a_3 = new Vector2((float)(point2.X - 8), (float)(point2.Y - 8));
							A_1.b().w5(texture2D, a_3, new Rectangle?(this.b), FreeItemSlotControl<T>.a);
						}
						else
						{
							Vector2 vector2 = (wj.cp.b() - base.Size.b()) / 2f;
							Vector2 a_4 = new Vector2((float)point2.X - vector2.X, (float)point2.Y - vector2.Y);
							A_1.b().w5(texture2D, a_4, new Rectangle?(this.b), FreeItemSlotControl<T>.a);
						}
					}
				}
			}
			base.iv(A_0, A_1);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006768 File Offset: 0x00004968
		protected override bool x7()
		{
			return (!this.f || c69.b()) && (!this.g || !c69.a());
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000679C File Offset: 0x0000499C
		protected override Rectangle? aia()
		{
			if (this.h != null)
			{
				Point point = this.h.at();
				return new Rectangle?(new Rectangle(point.X, point.Y, this.h.Size.c, this.h.Size.d));
			}
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006800 File Offset: 0x00004A00
		protected virtual bool aek(coh A_0)
		{
			return true;
		}

		// Token: 0x0400027E RID: 638
		private new static readonly Color a = Color.White * 0.7f;

		// Token: 0x0400027F RID: 639
		public new Rectangle b = new Rectangle(0, 66, 49, 49);

		// Token: 0x04000280 RID: 640
		public new Rectangle c = new Rectangle(98, 66, 49, 49);

		// Token: 0x04000281 RID: 641
		private new ItemSlot<T> d;

		// Token: 0x04000282 RID: 642
		private new string e;

		// Token: 0x04000283 RID: 643
		private new bool f = true;

		// Token: 0x04000284 RID: 644
		private new bool g = true;

		// Token: 0x04000285 RID: 645
		private new euz h;

		// Token: 0x04000286 RID: 646
		private new Func<coh> i;
	}
}
