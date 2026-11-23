using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CBE RID: 3262
[e79("Xpbl_KirillLab2_PlayerExitsAcid")]
public sealed class coa : dgy
{
	// Token: 0x06004970 RID: 18800 RVA: 0x001E84A4 File Offset: 0x001E66A4
	public coa()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			coa.a a = new coa.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				aud aud = a.a.Area;
				a.b = a.a.Zone.g("FromAcid");
				a.a.h.b.ap = new CharacterState?(CharacterState.Custom5);
				a.a.h.b.aq = new int?(0);
				a.a.Location = new Vector3(a.a.Location.X, a.a.Location.Y + 1f, a.a.Location.Z + 0.75f);
				a.a.ah();
				c5x c5x = new ar7(new Guid("356486ed-9174-4f94-886d-69db4106a478"), aud).ao() as c5x;
				if (c5x.h.b != null)
				{
					c5x.h.b.aa().StatusEffects.a(new aw3(0), false, false, false);
				}
				if (aud != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a(new ar7(a.a));
					c6w.IsAsync = false;
					c6w.a = new Func<auv>(a.a);
					array[num] = c6w;
					base.a(array);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.55))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new ace(new bu0("cp_mutantLab"))
					});
				}
			}
		}
	}

	// Token: 0x02000CBF RID: 3263
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004972 RID: 18802 RVA: 0x001E872C File Offset: 0x001E692C
		internal auv a()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new epw(new CharacterState?(CharacterState.Custom5)), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new b16(new int?(0)), null, null, null);
			a4s2.b(new ar7(this.a));
			list2.Add(a4s2);
			for (int i = 0; i <= 15; i++)
			{
				if (i == 1)
				{
					List<auv> list3 = awx.ad();
					a4s a4s3 = new a4s(new bfq("WaterSplashGiant"), null, null, null);
					a4s3.b(new ar7(this.a));
					list3.Add(a4s3);
					awx.ad().Add(new au0(this.a.Area, new Vector3(this.b.Location.X - 0.75f, this.b.Location.Y, this.b.Location.Z - 0.4f), "WaterSplashLargeDirty", 1, double.MaxValue, null, null, null));
				}
				List<auv> list4 = awx.ad();
				a4s a4s4 = new a4s(new b16(new int?(i)), null, null, null);
				a4s4.b(new ar7(this.a));
				list4.Add(a4s4);
				awx.ad().Add(new bm3(30));
			}
			return awx;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x001E88BC File Offset: 0x001E6ABC
		internal bool a(e6d A_0)
		{
			this.a.h.b.aq = new int?(0);
			this.a.h.b.ap = new CharacterState?(CharacterState.Idle);
			this.a.VisualDirection = HorizontalDirection.North;
			b4p b4p = Enumerable.FirstOrDefault<b4p>(this.a.h.b.aa().StatusEffects.Get<b4p>());
			if (b4p != null)
			{
				new a9l().h(this.a, this.a, null);
				this.a.h.b.aa().StatusEffects.d(b4p);
			}
			foreach (coh coh in Enumerable.ToList<coh>(this.a.h.b.aa().Bag.z2()))
			{
				if (coh.Definition.bc() != cr1.f)
				{
					this.a.h.b.aa().Bag.z5(coh);
				}
			}
			this.a.Location = new Vector3(this.b.Location.X - 0.75f, this.b.Location.Y - 1f, this.b.Location.Z);
			this.a.ah();
			return true;
		}

		// Token: 0x04001D11 RID: 7441
		public c5x a;

		// Token: 0x04001D12 RID: 7442
		public csd b;
	}
}
