using System;
using System.Runtime.Serialization;

// Token: 0x02001964 RID: 6500
[eiz("PAJPE")]
[Serializable]
public sealed class aj9 : wq, ISerializable
{
	// Token: 0x06008B08 RID: 35592 RVA: 0x0038E868 File Offset: 0x0038CA68
	private aj9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B09 RID: 35593 RVA: 0x0038E874 File Offset: 0x0038CA74
	public aj9()
	{
	}

	// Token: 0x06008B0A RID: 35594 RVA: 0x0038E880 File Offset: 0x0038CA80
	public override wq dn()
	{
		aj9 aj = new aj9();
		this.@do(aj);
		return aj;
	}

	// Token: 0x06008B0B RID: 35595 RVA: 0x0038E89C File Offset: 0x0038CA9C
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06008B0C RID: 35596 RVA: 0x0038E8AC File Offset: 0x0038CAAC
	public override void dl(ll A_0, int A_1)
	{
		if (A_0 != null && A_0.a() != null)
		{
			int num = new a9y().a(new eoj(A_0.a(), null, null));
			if (num != 0)
			{
				A_0.a().Offense.d(-num, true);
			}
		}
	}
}
