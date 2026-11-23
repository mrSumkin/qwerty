using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E94 RID: 3732
[e79("FacelessInvadeCoreCitySkip")]
public sealed class bmf : dgy
{
	// Token: 0x06004D65 RID: 19813 RVA: 0x00222D50 File Offset: 0x00220F50
	public bmf()
	{
		btm[] array = new btm[1];
		array[0] = new dva(null, new Func<e6d, bool>(bmf.a.a.a), null, null, null);
		base.a(array);
		btm[] array2 = new btm[1];
		int num = 0;
		dky dky = new dky();
		dky.a(0.2f);
		dky.a(false);
		array2[num] = dky;
		base.a(array2);
		base.a(new btm[]
		{
			new di4(new c2w("StationAlpha-Level5", "start"), false, null, 0, null, true, false, false)
		});
	}

	// Token: 0x02000E95 RID: 3733
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004D68 RID: 19816 RVA: 0x00222E14 File Offset: 0x00221014
		internal bool a(e6d A_0)
		{
			bpo.GetServiceOrThrow<cnk>().aqu().r()["hidePlayer"] = false;
			return true;
		}

		// Token: 0x04001F9F RID: 8095
		public static readonly bmf.a a = new bmf.a();

		// Token: 0x04001FA0 RID: 8096
		public static Func<e6d, bool> b;
	}
}
