using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200172B RID: 5931
[eiz("DDA")]
[Serializable]
public sealed class ef8 : a6k
{
	// Token: 0x06008015 RID: 32789 RVA: 0x00360F34 File Offset: 0x0035F134
	private ef8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008016 RID: 32790 RVA: 0x00360F40 File Offset: 0x0035F140
	public ef8()
	{
	}

	// Token: 0x06008017 RID: 32791 RVA: 0x00360F4C File Offset: 0x0035F14C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null && base.vg().q().i.b != null && base.vg().q().h.b.am() == bln.fc)
		{
			List<ak1> list = aw1.b(base.vg().q(), false);
			double num = double.MaxValue;
			ak1 ak = null;
			foreach (ak1 ak2 in list)
			{
				HorizontalDirection? horizontalDirection = aw1.a(base.vg().q(), ak2, false);
				HorizontalDirection horizontalDirection2 = base.vg().q().VisualDirection;
				if (horizontalDirection.GetValueOrDefault() == horizontalDirection2 & horizontalDirection != null)
				{
					double num2 = aw1.a(base.vg().q(), ak2);
					if (ak == null || num2 < num)
					{
						num = num2;
						ak = ak2;
					}
				}
			}
			if (ak != null)
			{
				base.vg().q().c().a("engine", false);
				base.vg().q().c().a("DreadnoughtDismount");
				awx awx = new awx();
				awx.a(m7.b);
				awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Custom4, dz6.b(cux.a), 0, null, 1));
				awx.ad().Add(new bm3(dz6.b(200)));
				awx.ad().Add(new a4s(new ef8.a(ak), new ar7(base.vg().q()), null, null));
				base.vg().q().i.b.a(awx, atp.a, true, false);
				return dc4.c;
			}
			bmj.a(base.vg().q(), new d53("Недостаточно места", adi.l, null, false));
			a7v.a(new h0("Недостаточно места чтобы выйти здесь.", new Color?(adi.l)));
		}
		return dc4.e;
	}

	// Token: 0x0200172C RID: 5932
	[eiz("DDAa")]
	[Serializable]
	private new sealed class a : cze
	{
		// Token: 0x06008018 RID: 32792 RVA: 0x003611C8 File Offset: 0x0035F3C8
		private a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = (A_0.GetValue("DAAa:T", typeof(edx)) as edx);
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x003611F4 File Offset: 0x0035F3F4
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("DAAa:T", this.a);
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x00361210 File Offset: 0x0035F410
		public a(ak1 A_0)
		{
			this.a = new edx(A_0);
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00361228 File Offset: 0x0035F428
		public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			c5x c5x = A_0 as c5x;
			if (serviceOrThrow != null && c5x != null && this.a != null && this.a.ao() != null)
			{
				if (!aw1.a(null, this.a.ao(), false, null))
				{
					c5x c5x2 = vq.a("object\\vehicles\\Dreadnought-Mountable", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
					if (c5x2 == null || c5x2.o.b == null)
					{
						return;
					}
					a3f a3f = c5x2.GetAspect<a3f>();
					if (a3f == null)
					{
						a3f = new a3f(c5x2);
						c5x2.SetAspect<a3f>(a3f);
					}
					a3f.a()["StoredHealth"] = c5x.h.b.aa().Defense.q().zo();
					c5x2.o.b.b = new Point(c5x2.o.b.b.X, (int)a63.b(c5x.VisualDirection));
					if (c5x2.s.b != null)
					{
						c5x2.s.b.a(new List<HorizontalDirection>
						{
							c5x.VisualDirection
						});
					}
					c5x.Location = this.a.ao().Location.a();
					c5x.ah();
					serviceOrThrow.aqu().r()[qu.b] = false;
					serviceOrThrow.aqu().r()[qu.a] = false;
					c5x.h.b.aa().AttributesBase |= d8o.b;
					c5x.h.b.aa().AttributesBase |= d8o.c;
					c5x.h.b.aa().AttributesBase &= ~d8o.e;
					c5x.h.b.aa().ImmunitiesBase &= ~CharacterImmunities.Caltrops;
					c5x.h.b.a((c5x.h.b.aa().Gender == Gender.Male) ? bln.a : bln.b);
					c5x.Size = new Vector3(1f, 1f, 1.65f);
					c5x.h.b.a(ai5.b);
					c5x.h.b.aa().CustomProperties.RemoveProperty(ddm.b);
					c5x.h.b.aa().CustomProperties.RemoveProperty(ddm.f);
					c5x.h.b.ay().Clear();
					ex ex = Enumerable.FirstOrDefault<ex>(c5x.h.b.aa().StatusEffects.Get<ex>());
					if (ex != null)
					{
						c5x.h.b.aa().StatusEffects.d(ex);
					}
					c5x.h.b.aa().az();
					float? primitivePropertyValue = c5x.h.b.aa().CustomProperties.GetPrimitivePropertyValue<float>("StoredHealth", null);
					if (primitivePropertyValue != null)
					{
						c5x.h.b.aa().Defense.q().zp(primitivePropertyValue.Value);
					}
					string classPropertyValue = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<string>("StoredPortrait");
					c5x.h.b.aa().Portrait = classPropertyValue;
					c5x.h.b.aa().CustomProperties.RemoveProperty("StoredPortrait");
					d60 d = c5x.Zone.a();
					if (d == null)
					{
						return;
					}
					using (List<b0b>.Enumerator enumerator = d.ab4(new string[]
					{
						"dreadnoughtBarricade"
					}).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							b0b b0b = enumerator.Current;
							b0b.TileFormationModifiers.s4(1);
							b0b.z();
						}
						return;
					}
				}
				bmj.a(A_0, new d53("Недостаточно места", adi.l, null, false));
				a7v.a(new h0("Недостаточно места чтобы выйти здесь.", new Color?(adi.l)));
			}
		}

		// Token: 0x0400323E RID: 12862
		private new edx a;
	}
}
