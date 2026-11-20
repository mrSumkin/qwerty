using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001957 RID: 6487
[eiz("VBI")]
[Serializable]
public sealed class esd : b81, ISerializable
{
	// Token: 0x06008A78 RID: 35448 RVA: 0x0038CF9C File Offset: 0x0038B19C
	private esd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008A79 RID: 35449 RVA: 0x0038CFA8 File Offset: 0x0038B1A8
	public override VehiclePartType qp()
	{
		return VehiclePartType.Battery;
	}

	// Token: 0x06008A7A RID: 35450 RVA: 0x0038CFAC File Offset: 0x0038B1AC
	public esd()
	{
	}

	// Token: 0x06008A7B RID: 35451 RVA: 0x0038CFB8 File Offset: 0x0038B1B8
	public override void qq(bcx A_0, agt A_1)
	{
		if (base.ba() != null)
		{
			A_0.a(A_0.am() + base.ba().Value);
		}
	}

	// Token: 0x06008A7C RID: 35452 RVA: 0x0038CFF4 File Offset: 0x0038B1F4
	public override bk3 tw()
	{
		esd esd = new esd();
		this.ai7(esd);
		return esd;
	}
}
