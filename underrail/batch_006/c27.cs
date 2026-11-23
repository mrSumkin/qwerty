using System;
using System.Runtime.Serialization;

// Token: 0x0200193F RID: 6463
[eiz("BI1")]
[elw(typeof(cjh))]
[Serializable]
public sealed class c27 : diz, ISerializable
{
	// Token: 0x06008927 RID: 35111 RVA: 0x0038931C File Offset: 0x0038751C
	private c27(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(c27);
		}
	}

	// Token: 0x06008928 RID: 35112 RVA: 0x00389348 File Offset: 0x00387548
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06008929 RID: 35113 RVA: 0x00389354 File Offset: 0x00387554
	public override string tv()
	{
		return "Пояс";
	}

	// Token: 0x0600892A RID: 35114 RVA: 0x0038935C File Offset: 0x0038755C
	public c27()
	{
	}

	// Token: 0x0600892B RID: 35115 RVA: 0x00389368 File Offset: 0x00387568
	public override bk3 tw()
	{
		c27 c = new c27();
		this.ai7(c);
		return c;
	}
}
