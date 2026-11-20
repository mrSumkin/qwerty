using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Rules.Items;

namespace TimelapseVertigo.UI.Controls
{
	// Token: 0x0200004D RID: 77
	public class PlayerGearItemSlotControl<T> : FreeItemSlotControl<T> where T : coh
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00005A08 File Offset: 0x00003C08
		public override bool ya()
		{
			return this.ah8();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005A10 File Offset: 0x00003C10
		public PlayerGearItemSlotControl(ItemSlot<T> A_0, string A_1, esj A_2, esj A_3) : base(A_0, A_2, A_3)
		{
			this.a = A_1;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005A2C File Offset: 0x00003C2C
		public PlayerGearItemSlotControl(ItemSlot<T> A_0, string A_1) : base(A_0)
		{
			this.a = A_1;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005A44 File Offset: 0x00003C44
		public override coh yb(coh A_0, bool A_1 = false)
		{
			if (A_0 is T)
			{
				return base.yb(A_0, A_1);
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				serviceOrThrow.aqu().v().Bag.z3(A_0, true);
			}
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005AA0 File Offset: 0x00003CA0
		public override bool iq(e08 A_0)
		{
			return !(A_0.a() is emy) && base.iq(A_0);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public override ecs yf(euz A_0)
		{
			ecs ecs = base.yf(A_0);
			if (ecs == null)
			{
				return new ecs
				{
					a = 
					{
						new dl6(new bph[]
						{
							new bph(new d22(cq4.d(), Color.Gray), this.a, null)
						})
					}
				};
			}
			return ecs;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005B18 File Offset: 0x00003D18
		protected override void rd(object A_0, b25 A_1)
		{
			base.rd(A_0, A_1);
			if (d4f.b() && base.zf())
			{
				d4f.b(this);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005B40 File Offset: 0x00003D40
		public override void yc(coh A_0, int A_1, int A_2)
		{
			base.yc(A_0, A_1, A_2);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				serviceOrThrow.aqu().v().bl();
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005B88 File Offset: 0x00003D88
		protected override void aqp(e6d A_0, cp9 A_1)
		{
			if (this.b >= 0)
			{
				wj wj = wj.a();
				if (!wj.c() && this.x6() == null && this.ah8())
				{
					Texture2D texture2D = A_1.a.us(wj.f, null);
					if (texture2D != null)
					{
						chr service = bpo.GetService<chr>();
						bool flag = bpo.GetServiceOrThrow<d1a>().aa8() == this && service != null && service.ax() != null && this.iq(service.ax());
						Point point = base.at();
						point.X += (base.Size.c - wj.cu.c) / 2;
						point.Y += (base.Size.d - wj.cu.d) / 2;
						Rectangle value = new Rectangle(wj.ct.X, wj.ct.Y + wj.cu.d * this.b, wj.cu.c, wj.cu.d);
						Rectangle a_ = new Rectangle(point.X, point.Y, wj.cu.c, wj.cu.d);
						A_1.b().w6(texture2D, a_, new Rectangle?(value), flag ? Color.Black : (base.Color * 0.8f));
					}
				}
			}
		}

		// Token: 0x0400027C RID: 636
		private new string a;

		// Token: 0x0400027D RID: 637
		public new int b = -1;
	}
}
