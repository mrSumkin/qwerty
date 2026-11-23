using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000334 RID: 820
[apc("dreadnoughtPilot")]
public sealed class e2n : esk
{
	// Token: 0x0600175E RID: 5982 RVA: 0x00075D44 File Offset: 0x00073F44
	public e2n()
	{
		this.a = new a6w(null);
		this.j.a.Insert(0, new arr(this.a, new Func<e1k, bool>(e2n.a.a.a)));
		this.a.a = new Func<a6w, cst>(e2n.a.a.a);
		this.a.a = this.c;
		this.a.b = this.c;
	}

	// Token: 0x04000DE8 RID: 3560
	private new a6w a;

	// Token: 0x02000335 RID: 821
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001761 RID: 5985 RVA: 0x00075E04 File Offset: 0x00074004
		internal bool a(e1k A_0)
		{
			d60 d = A_0.c().a8().Zone.a();
			if (d != null && A_0.g().aa().IsInControl)
			{
				string classPropertyValue = A_0.c().y6().GetClassPropertyValue<string>(ddq.by);
				if (!string.IsNullOrEmpty(classPropertyValue) && bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue, new bool?(false)).Value)
				{
					string classPropertyValue2 = A_0.c().y6().GetClassPropertyValue<string>(ddq.bx);
					if (!string.IsNullOrEmpty(classPropertyValue2) && d.ab5(classPropertyValue2) is c5x)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00075EC0 File Offset: 0x000740C0
		internal cst a(a6w A_0)
		{
			d60 d = A_0.b().c().a8().Zone.a();
			if (d != null)
			{
				string classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<string>(ddq.bx);
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c5x c5x = d.ab5(classPropertyValue) as c5x;
					if (c5x != null)
					{
						Guid guid = Guid.NewGuid();
						awx awx = new awx();
						awx.a(m7.b | m7.k);
						awx.a(false);
						awx.ad().Add(new fk(A_0.b().c().a8().GetAspect<ale>(), c5x, new List<HorizontalDirection>
						{
							c5x.VisualDirection
						}, false, 0));
						awx.ad().Add(new e4t(A_0.b().g(), CharacterState.OperateShort, dz6.b(cux.a), 0, null, 1));
						List<auv> list = awx.ad();
						ch3 ch = new ch3();
						ch.a(new float?(0f));
						list.Add(new a4s(ch, null, new ar7(A_0.b().g().a8()), null));
						awx.ad().Add(new a4s(new ezd("Locale\\Creatures\\Machines\\Dreadnought", new bt4(c5x.Area.y8(), c5x.Location), new HorizontalDirection?(c5x.VisualDirection), new Guid?(guid), new CharacterState?(CharacterState.Custom3), new int?(0), null), null, null, null));
						List<auv> list2 = awx.ad();
						dve dve = new dve();
						dve.a(A_0.b().g().aa().FactionId);
						list2.Add(new a4s(dve, null, new ar7(guid, A_0.b().g().a8().Area), null));
						awx.ad().Add(new c7(c5x, false, false, true, false));
						awx.ad().Add(new c7(A_0.b().g().a8(), false, false, true, false));
						awx.ad().Add(new g1(new EntityAspectReference<ny, ny>(c5x.Area, guid), new e4t(new EntityAspectReference<amc, amc>(c5x.Area, guid), CharacterState.Custom3, dz6.b(cux.a), 0, null, 1), atp.a, false));
						awx.ad().Add(new bm3(dz6.b(150)));
						awx.ad().Add(new a4s(new epw(null), null, new ar7(guid, c5x.Area), null));
						awx.ad().Add(new a4s(new b16(null), null, new ar7(guid, c5x.Area), null));
						A_0.b().i().b(awx, atp.a);
						return awx;
					}
				}
			}
			return null;
		}

		// Token: 0x04000DE9 RID: 3561
		public static readonly e2n.a a = new e2n.a();

		// Token: 0x04000DEA RID: 3562
		public static Func<e1k, bool> b;

		// Token: 0x04000DEB RID: 3563
		public static Func<a6w, cst> c;
	}
}
