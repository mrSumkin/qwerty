using System;
using System.Runtime.Serialization;

// Token: 0x02001A4D RID: 6733
[eiz("SE4")]
[Serializable]
public sealed class df : d3e, ISerializable
{
	// Token: 0x06009218 RID: 37400 RVA: 0x0039E874 File Offset: 0x0039CA74
	private df(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(df);
		}
	}

	// Token: 0x06009219 RID: 37401 RVA: 0x0039E8A0 File Offset: 0x0039CAA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600921A RID: 37402 RVA: 0x0039E8AC File Offset: 0x0039CAAC
	public df()
	{
		base.Priority = int.MinValue;
	}

	// Token: 0x0600921B RID: 37403 RVA: 0x0039E8C0 File Offset: 0x0039CAC0
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.g = true;
		A_0.a().Offense.s();
	}

	// Token: 0x0600921C RID: 37404 RVA: 0x0039E8F0 File Offset: 0x0039CAF0
	public override d3e b3()
	{
		df df = new df();
		this.xx(df);
		return df;
	}
}
