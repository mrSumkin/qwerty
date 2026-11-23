using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common.Aspects;

// Token: 0x02000F84 RID: 3972
[eiz("DCECLEA")]
[Serializable]
public sealed class bvs : Aspect<c5x>, cmm, chb
{
	// Token: 0x060050D5 RID: 20693 RVA: 0x002465A8 File Offset: 0x002447A8
	private bvs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("DCECLEA:C");
	}

	// Token: 0x060050D6 RID: 20694 RVA: 0x002465C4 File Offset: 0x002447C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCECLEA:C", this.b);
	}

	// Token: 0x060050D7 RID: 20695 RVA: 0x002465E0 File Offset: 0x002447E0
	public bvs(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050D8 RID: 20696 RVA: 0x002465EC File Offset: 0x002447EC
	public void c9(TimeSpan A_0)
	{
		this.b += A_0.TotalMilliseconds;
	}

	// Token: 0x060050D9 RID: 20697 RVA: 0x00246604 File Offset: 0x00244804
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060050DA RID: 20698 RVA: 0x00246608 File Offset: 0x00244808
	public void r7(eds A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
		int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
		int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
		if (value != value2)
		{
			c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), base.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				aru aru = c5x.c();
				SoundState? soundState = aru.b("elevator");
				SoundState soundState2 = SoundState.Playing;
				if (!(soundState.GetValueOrDefault() == soundState2 & soundState != null))
				{
					aru.a("elevator", false);
					aru.a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
				}
			}
		}
		if (!dz6.e())
		{
			this.b += A_0.b.TotalMilliseconds;
		}
		this.b();
		value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
		afi.a(base.a8(), value3);
	}

	// Token: 0x060050DB RID: 20699 RVA: 0x0024676C File Offset: 0x0024496C
	public void c()
	{
		this.b += (double)d0u.b;
		this.b();
	}

	// Token: 0x060050DC RID: 20700 RVA: 0x0024678C File Offset: 0x0024498C
	private void b()
	{
		while (this.b >= (double)bvs.a)
		{
			this.b -= (double)bvs.a;
			if (!this.a())
			{
				this.b = 0.0;
				return;
			}
		}
	}

	// Token: 0x060050DD RID: 20701 RVA: 0x002467DC File Offset: 0x002449DC
	private bool a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
			int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
			afi.a(base.a8(), value3);
			if (value2 == 0 && (value3 != 0 || value == 1))
			{
				afi.d(base.a8());
				return true;
			}
			if (value2 == 1 && (value3 != afi.a || value == 0))
			{
				afi.c(base.a8());
				return true;
			}
		}
		return false;
	}

	// Token: 0x04002124 RID: 8484
	private static readonly int a = d0u.b;

	// Token: 0x04002125 RID: 8485
	private double b;
}
