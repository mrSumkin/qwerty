using System;
using System.Runtime.Serialization;

// Token: 0x02001924 RID: 6436
[eiz("FI")]
[Serializable]
public class a3e : cv9, ISerializable
{
	// Token: 0x060088A0 RID: 34976 RVA: 0x003883BC File Offset: 0x003865BC
	protected a3e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060088A1 RID: 34977 RVA: 0x003883C8 File Offset: 0x003865C8
	public override string tv()
	{
		return "Еда";
	}

	// Token: 0x060088A2 RID: 34978 RVA: 0x003883D0 File Offset: 0x003865D0
	public override bk3 tw()
	{
		a3e a3e = new a3e();
		this.ai7(a3e);
		return a3e;
	}

	// Token: 0x060088A3 RID: 34979 RVA: 0x003883EC File Offset: 0x003865EC
	public a3e()
	{
	}
}
