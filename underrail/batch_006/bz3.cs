using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000D6A RID: 3434
[e79("Xpbl_Sgs_GonzoHitsYe")]
public sealed class bz3 : dgy
{
	// Token: 0x06004AEB RID: 19179 RVA: 0x00202F2C File Offset: 0x0020112C
	public bz3()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bz3.a a = new bz3.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_pir_gonzo_slappedOnce", new int?(0)).Value;
			if (a.a != null && a.a.h.b != null)
			{
				a.b = (new ar7(new Guid("97253405-abc1-417e-8f32-5a01aec779b7"), a.a.Area).ao() as c5x);
				if (a.b != null && a.b.h.b != null)
				{
					if (a.a.h.b.aa().Defense.q().zo() >= 2f)
					{
						a.a.h.b.aa().Defense.a(new cwt
						{
							b = true,
							p = false,
							l = true,
							f = new List<csk>
							{
								new csk(DamageType.Mechanical, Math.Min(15, (int)(a.a.h.b.aa().Defense.q().zo() - 1f)))
							},
							i = new ap9(a.b.h.b.aa())
						});
					}
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a = new Func<auv>(a.a);
					c6w.a(new ar7(a.b));
					array[num] = c6w;
					base.a(array);
					base.a(new btm[]
					{
						new ace(new bfq(Guid.NewGuid().ToString(), "UnarmedWoosh"))
						{
							TargetRef = new ar7(a.a)
						}
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Attack1);
					bb.a(cux.m);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.b));
					bb.b(1);
					array2[num2] = bb;
					base.a(array2);
					base.a(new btm[]
					{
						new ace(new bfq(Guid.NewGuid().ToString(), "UnarmedHitBody"))
						{
							TargetRef = new ar7(a.a)
						}
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D6B RID: 3435
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AED RID: 19181 RVA: 0x00203220 File Offset: 0x00201420
		internal auv a()
		{
			return new fk(this.b.k.b, this.a, new List<HorizontalDirection>
			{
				this.a.VisualDirection
			}, true, 0);
		}

		// Token: 0x04001E09 RID: 7689
		public c5x a;

		// Token: 0x04001E0A RID: 7690
		public c5x b;
	}
}
