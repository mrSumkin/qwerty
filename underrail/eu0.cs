using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001955 RID: 6485
[eiz("JSI")]
[Serializable]
public sealed class eu0 : dv2, ISerializable
{
	// Token: 0x06008A6D RID: 35437 RVA: 0x0038CED4 File Offset: 0x0038B0D4
	private eu0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008A6E RID: 35438 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
	public override VehiclePartType qp()
	{
		return VehiclePartType.JetskiSuspension;
	}

	// Token: 0x06008A6F RID: 35439 RVA: 0x0038CEE4 File Offset: 0x0038B0E4
	public eu0()
	{
	}

	// Token: 0x06008A70 RID: 35440 RVA: 0x0038CEF0 File Offset: 0x0038B0F0
	public override bk3 tw()
	{
		eu0 eu = new eu0();
		this.ai7(eu);
		return eu;
	}
}
