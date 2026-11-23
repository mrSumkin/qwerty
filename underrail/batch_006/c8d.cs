using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200193A RID: 6458
[eiz("ASII")]
[Serializable]
public sealed class c8d : cgk, IItemInstance<c43>, ISerializable
{
	// Token: 0x06008906 RID: 35078 RVA: 0x00388EB4 File Offset: 0x003870B4
	private c8d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(c8d);
		}
	}

	// Token: 0x06008907 RID: 35079 RVA: 0x00388EE0 File Offset: 0x003870E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06008908 RID: 35080 RVA: 0x00388EEC File Offset: 0x003870EC
	public new c43 fu()
	{
		return base.Definition as c43;
	}

	// Token: 0x06008909 RID: 35081 RVA: 0x00388EFC File Offset: 0x003870FC
	public c8d(bit A_0) : base(A_0)
	{
	}

	// Token: 0x0600890A RID: 35082 RVA: 0x00388F08 File Offset: 0x00387108
	public override coh fy()
	{
		c8d c8d = new c8d(base.DefinitionProvider.wm());
		this.fz(c8d);
		return c8d;
	}
}
