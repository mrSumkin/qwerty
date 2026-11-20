using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common.Aspects;

// Token: 0x02000F83 RID: 3971
[eiz("DCECUEA")]
[Serializable]
public sealed class co9 : Aspect<c5x>, cmm, chb
{
	// Token: 0x060050CB RID: 20683 RVA: 0x0024623C File Offset: 0x0024443C
	private co9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("DCECUEA:C");
	}

	// Token: 0x060050CC RID: 20684 RVA: 0x00246258 File Offset: 0x00244458
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCECUEA:C", this.b);
	}

	// Token: 0x060050CD RID: 20685 RVA: 0x00246274 File Offset: 0x00244474
	public co9(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050CE RID: 20686 RVA: 0x00246280 File Offset: 0x00244480
	public void c9(TimeSpan A_0)
	{
		this.b += A_0.TotalMilliseconds;
	}

	// Token: 0x060050CF RID: 20687 RVA: 0x00246298 File Offset: 0x00244498
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060050D0 RID: 20688 RVA: 0x0024629C File Offset: 0x0024449C
	public void r7(eds A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
		int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
		int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
		if (value != value2)
		{
			c5x c5x = new ar7(new Guid("32bde564-a3aa-40cb-8a5f-0a5f2af3c013"), base.a8().Area).ao() as c5x;
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
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(3);
					if (value2 == 1)
					{
						etz.b(-1);
						etz.a(2);
					}
					else
					{
						etz.b(1);
						etz.a(0);
					}
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

	// Token: 0x060050D1 RID: 20689 RVA: 0x00246450 File Offset: 0x00244650
	public void c()
	{
		this.b += (double)d0u.b;
		this.b();
	}

	// Token: 0x060050D2 RID: 20690 RVA: 0x0024646C File Offset: 0x0024466C
	private void b()
	{
		while (this.b >= (double)co9.a)
		{
			this.b -= (double)co9.a;
			if (!this.a())
			{
				this.b = 0.0;
				return;
			}
		}
	}

	// Token: 0x060050D3 RID: 20691 RVA: 0x002464BC File Offset: 0x002446BC
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
				afi.a(base.a8());
				return true;
			}
			if (value2 == 1 && (value3 != afi.a || value == 0))
			{
				afi.b(base.a8());
				return true;
			}
		}
		return false;
	}

	// Token: 0x04002122 RID: 8482
	private static readonly int a = d0u.b;

	// Token: 0x04002123 RID: 8483
	private double b;
}
