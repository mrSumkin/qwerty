using System;
using System.Runtime.Serialization;

// Token: 0x02001A23 RID: 6691
[eiz("SE9")]
[Serializable]
public sealed class eab : d3e, ISerializable
{
	// Token: 0x060090E3 RID: 37091 RVA: 0x0039BB08 File Offset: 0x00399D08
	private eab(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060090E4 RID: 37092 RVA: 0x0039BB14 File Offset: 0x00399D14
	public eab()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x060090E5 RID: 37093 RVA: 0x0039BB28 File Offset: 0x00399D28
	public override d3e b3()
	{
		eab eab = new eab();
		this.xx(eab);
		return eab;
	}

	// Token: 0x060090E6 RID: 37094 RVA: 0x0039BB44 File Offset: 0x00399D44
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.k = true;
		A_0.a().Defense.a(0);
		A_0.a().Defense.c(0);
	}
}
