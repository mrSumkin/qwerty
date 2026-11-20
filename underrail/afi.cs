using System;
using Microsoft.Xna.Framework;

// Token: 0x020007CC RID: 1996
public static class afi
{
	// Token: 0x06003211 RID: 12817 RVA: 0x00133C6C File Offset: 0x00131E6C
	public static void d(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
			int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
			num2 = Math.Max(0, num2 - 1);
			afi.a(A_0, num2);
			if (num2 == 0)
			{
				num = value;
				bpo.GetServiceOrThrow<ps>().am3("Dc_ElevatorDescends");
			}
			serviceOrThrow.aqu().r()["loc_dc_elevator_position"] = num;
			serviceOrThrow.aqu().r()["loc_dc_elevator_target"] = value;
			serviceOrThrow.aqu().r()["loc_dc_elevatorStage"] = num2;
		}
	}

	// Token: 0x06003212 RID: 12818 RVA: 0x00133D78 File Offset: 0x00131F78
	public static void c(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
			int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
			num2 = Math.Min(afi.a, num2 + 1);
			afi.a(A_0, num2);
			if (num2 == afi.a)
			{
				num = value;
				c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), A_0.Area).ao() as c5x;
				if (c5x != null)
				{
					c5x.c().a("elevator", false);
				}
			}
			serviceOrThrow.aqu().r()["loc_dc_elevator_position"] = num;
			serviceOrThrow.aqu().r()["loc_dc_elevator_target"] = value;
			serviceOrThrow.aqu().r()["loc_dc_elevatorStage"] = num2;
		}
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x00133EB8 File Offset: 0x001320B8
	public static void b(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
			int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
			num2 = Math.Min(afi.a, num2 + 1);
			afi.a(A_0, num2);
			if (num2 == afi.a)
			{
				num = value;
				bpo.GetServiceOrThrow<ps>().am3("Cv_ElevatorAscends");
			}
			serviceOrThrow.aqu().r()["loc_dc_elevator_position"] = num;
			serviceOrThrow.aqu().r()["loc_dc_elevator_target"] = value;
			serviceOrThrow.aqu().r()["loc_dc_elevatorStage"] = num2;
		}
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x00133FCC File Offset: 0x001321CC
	public static void a(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
			int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
			num2 = Math.Max(0, num2 - 1);
			afi.a(A_0, num2);
			if (num2 == 0)
			{
				num = value;
				c5x c5x = new ar7(new Guid("32bde564-a3aa-40cb-8a5f-0a5f2af3c013"), A_0.Area).ao() as c5x;
				if (c5x != null)
				{
					c5x.c().a("elevator", false);
					etz etz = c5x.o.b as etz;
					if (etz != null)
					{
						etz.c(0);
					}
				}
			}
			serviceOrThrow.aqu().r()["loc_dc_elevator_position"] = num;
			serviceOrThrow.aqu().r()["loc_dc_elevator_target"] = value;
			serviceOrThrow.aqu().r()["loc_dc_elevatorStage"] = num2;
		}
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x00134124 File Offset: 0x00132324
	public static void a(c5x A_0, int A_1)
	{
		if (A_0.p.b != null)
		{
			foreach (cd0 cd in A_0.p.b.a)
			{
				cd.b = new Point(A_1, cd.b.Y);
			}
		}
	}

	// Token: 0x04001ADA RID: 6874
	public static readonly int a = 6;
}
