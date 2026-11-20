using System;
using System.Runtime.Serialization;

// Token: 0x02001336 RID: 4918
[eiz("BA1")]
[Serializable]
public sealed class avh : b1z, ISerializable
{
	// Token: 0x06006F6A RID: 28522 RVA: 0x002EC5D0 File Offset: 0x002EA7D0
	private avh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("BA1:SR", typeof(ar7));
			return;
		}
		if (base.GetType() == typeof(avh))
		{
			this.a = (ar7)A_0.GetValue("_SubjectRef", typeof(ar7));
			return;
		}
		this.a = (ar7)A_0.GetValue("BarterAction+_SubjectRef", typeof(ar7));
	}

	// Token: 0x06006F6B RID: 28523 RVA: 0x002EC66C File Offset: 0x002EA86C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BA1:SR", this.a);
	}

	// Token: 0x06006F6C RID: 28524 RVA: 0x002EC688 File Offset: 0x002EA888
	public override m7 kh()
	{
		return m7.b | m7.h;
	}

	// Token: 0x06006F6D RID: 28525 RVA: 0x002EC68C File Offset: 0x002EA88C
	public c5x a()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06006F6E RID: 28526 RVA: 0x002EC6A0 File Offset: 0x002EA8A0
	public avh(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x06006F6F RID: 28527 RVA: 0x002EC6B4 File Offset: 0x002EA8B4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.b;
	}

	// Token: 0x04002D8E RID: 11662
	private new ar7 a;
}
