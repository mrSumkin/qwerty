using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003AA RID: 938
[fe("dreadnoughtPilot")]
public sealed class el1 : b5g
{
	// Token: 0x060019CE RID: 6606 RVA: 0x0008A390 File Offset: 0x00088590
	public el1(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("Mount dreadnought", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(el1.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x0008A410 File Offset: 0x00088610
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		d60 d = this.Subject.a8().Zone.a();
		if (d != null && base.h().aa().IsInControl)
		{
			string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.by);
			if (!string.IsNullOrEmpty(classPropertyValue) && bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue, new bool?(false)).Value)
			{
				string classPropertyValue2 = this.Subject.y6().GetClassPropertyValue<string>(ddq.bx);
				if (!string.IsNullOrEmpty(classPropertyValue2) && d.ab5(classPropertyValue2) is c5x)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0008A4CC File Offset: 0x000886CC
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		d60 d = this.Subject.a8().Zone.a();
		if (d != null)
		{
			string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.bx);
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				c5x c5x = d.ab5(classPropertyValue) as c5x;
				if (c5x != null)
				{
					Guid guid = Guid.NewGuid();
					awx awx = new awx();
					awx.a(m7.b | m7.k);
					awx.a(false);
					awx.ad().Add(new fk(this.Subject.a8().GetAspect<ale>(), c5x, new List<HorizontalDirection>
					{
						c5x.VisualDirection
					}, false, 0));
					awx.ad().Add(new e4t(base.h(), CharacterState.OperateShort, cux.a, 0, null, 1));
					List<auv> list = awx.ad();
					ch3 ch = new ch3();
					ch.a(new float?(0f));
					list.Add(new a4s(ch, null, new ar7(this.Subject.a8()), null));
					awx.ad().Add(new a4s(new ezd("Locale\\Creatures\\Machines\\Dreadnought", new bt4(c5x.Area.y8(), c5x.Location), new HorizontalDirection?(c5x.VisualDirection), new Guid?(guid), new CharacterState?(CharacterState.Custom3), new int?(0), null), null, null, null));
					List<auv> list2 = awx.ad();
					dve dve = new dve();
					dve.a(base.h().aa().FactionId);
					list2.Add(new a4s(dve, null, new ar7(guid, this.Subject.a8().Area), null));
					awx.ad().Add(new c7(c5x, false, false, true, false));
					awx.ad().Add(new c7(this.Subject.a8(), false, false, true, false));
					awx.ad().Add(new g1(new EntityAspectReference<ny, ny>(c5x.Area, guid), new e4t(new EntityAspectReference<amc, amc>(c5x.Area, guid), CharacterState.Custom3, cux.a, 0, null, 1), atp.a, false));
					awx.ad().Add(new bm3(150));
					awx.ad().Add(new a4s(new epw(null), null, new ar7(guid, c5x.Area), null));
					awx.ad().Add(new a4s(new b16(null), null, new ar7(guid, c5x.Area), null));
					this.Subject.a8().i.b.b(awx, atp.a);
					return awx;
				}
			}
		}
		return null;
	}

	// Token: 0x020003AB RID: 939
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019D3 RID: 6611 RVA: 0x0008A798 File Offset: 0x00088998
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000E95 RID: 3733
		public static readonly el1.a a = new el1.a();

		// Token: 0x04000E96 RID: 3734
		public static Func<bool, float> b;
	}
}
