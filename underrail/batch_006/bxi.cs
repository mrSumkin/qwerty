using System;
using System.Runtime.Serialization;

// Token: 0x02001A24 RID: 6692
[eiz("NDX")]
[Serializable]
public sealed class bxi : d3e, ISerializable
{
	// Token: 0x060090E7 RID: 37095 RVA: 0x0039BB84 File Offset: 0x00399D84
	private bxi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060090E8 RID: 37096 RVA: 0x0039BB90 File Offset: 0x00399D90
	public bxi()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x060090E9 RID: 37097 RVA: 0x0039BBA4 File Offset: 0x00399DA4
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.j = true;
	}

	// Token: 0x060090EA RID: 37098 RVA: 0x0039BBB8 File Offset: 0x00399DB8
	public override d3e b3()
	{
		a1s a1s = new a1s();
		this.xx(a1s);
		return a1s;
	}
}
