using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200195C RID: 6492
[eiz("SBCI")]
[Serializable]
public class c51 : a1k, ISerializable
{
	// Token: 0x06008AB8 RID: 35512 RVA: 0x0038D944 File Offset: 0x0038BB44
	protected c51(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<f1>("SBCI:S", ref this.a, A_0);
	}

	// Token: 0x06008AB9 RID: 35513 RVA: 0x0038D96C File Offset: 0x0038BB6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<f1>("SBCI:S", this.a, info);
	}

	// Token: 0x06008ABA RID: 35514 RVA: 0x0038D988 File Offset: 0x0038BB88
	public new List<f1> a()
	{
		return this.a;
	}

	// Token: 0x06008ABB RID: 35515 RVA: 0x0038D990 File Offset: 0x0038BB90
	public c51()
	{
	}

	// Token: 0x06008ABC RID: 35516 RVA: 0x0038D9A8 File Offset: 0x0038BBA8
	public override bk3 tw()
	{
		c51 c = new c51();
		this.ai7(c);
		return c;
	}

	// Token: 0x06008ABD RID: 35517 RVA: 0x0038D9C4 File Offset: 0x0038BBC4
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		((c51)A_0).a = new List<f1>(this.a);
	}

	// Token: 0x0400371B RID: 14107
	private new List<f1> a = new List<f1>();
}
