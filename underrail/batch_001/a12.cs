using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001941 RID: 6465
[eiz("BII")]
[Serializable]
public sealed class a12 : cgk, IItemInstance<c5s>, ISerializable
{
	// Token: 0x06008937 RID: 35127 RVA: 0x0038965C File Offset: 0x0038785C
	private a12(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(a12);
		}
	}

	// Token: 0x06008938 RID: 35128 RVA: 0x00389688 File Offset: 0x00387888
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06008939 RID: 35129 RVA: 0x00389694 File Offset: 0x00387894
	public new c5s fu()
	{
		return base.Definition as c5s;
	}

	// Token: 0x0600893A RID: 35130 RVA: 0x003896A4 File Offset: 0x003878A4
	public a12(bit A_0) : base(A_0)
	{
	}

	// Token: 0x0600893B RID: 35131 RVA: 0x003896B0 File Offset: 0x003878B0
	public override coh fy()
	{
		a12 a = new a12(base.DefinitionProvider.wm());
		this.fz(a);
		return a;
	}
}
