using System;
using System.Runtime.Serialization;

// Token: 0x02001918 RID: 6424
[elw(typeof(d48))]
[eiz("KI2")]
[Serializable]
public sealed class a0z : dj3, ISerializable
{
	// Token: 0x0600887B RID: 34939 RVA: 0x00387C98 File Offset: 0x00385E98
	private a0z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600887C RID: 34940 RVA: 0x00387CA4 File Offset: 0x00385EA4
	public override string tv()
	{
		return "Ключ";
	}

	// Token: 0x0600887D RID: 34941 RVA: 0x00387CAC File Offset: 0x00385EAC
	public a0z()
	{
	}

	// Token: 0x0600887E RID: 34942 RVA: 0x00387CB8 File Offset: 0x00385EB8
	public override bk3 tw()
	{
		a0z a0z = new a0z();
		this.ai7(a0z);
		return a0z;
	}
}
