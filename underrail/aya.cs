using System;

// Token: 0x02001162 RID: 4450
public static class aya
{
	// Token: 0x06005F31 RID: 24369 RVA: 0x00285F20 File Offset: 0x00284120
	public static bool b(amc A_0)
	{
		return A_0 != null && A_0.aa().Vehicle != null;
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x00285F3C File Offset: 0x0028413C
	public static bool a(amc A_0)
	{
		return A_0 != null && A_0.aa().Vehicle != null && (A_0.aa().Vehicle.y() == bws.b || A_0.aa().Vehicle.y() == bws.a);
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x00285F8C File Offset: 0x0028418C
	public static bool a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && aya.a((serviceOrThrow.aqu().v().b() as c5x).h.b);
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x00285FE0 File Offset: 0x002841E0
	public static string a(string A_0)
	{
		return aya.a + A_0;
	}

	// Token: 0x040025DF RID: 9695
	public static readonly string a = "VehicleStatus_";
}
