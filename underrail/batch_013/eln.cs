using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;

// Token: 0x02000ACC RID: 2764
[eiz("XPHWGTCJ")]
[Serializable]
public sealed class eln : cze, ISerializable
{
	// Token: 0x06004071 RID: 16497 RVA: 0x0018828C File Offset: 0x0018648C
	private eln(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Xphw_GunslingerCommentCodeEnum)A_0.GetValue("XPHWGTCJ:CC", typeof(Xphw_GunslingerCommentCodeEnum));
		this.b = A_0.GetBoolean("XPHWGTCJ:R");
	}

	// Token: 0x06004072 RID: 16498 RVA: 0x001882C8 File Offset: 0x001864C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGTCJ:CC", this.a);
		info.AddValue("XPHWGTCJ:R", this.b);
	}

	// Token: 0x06004073 RID: 16499 RVA: 0x001882FC File Offset: 0x001864FC
	public Xphw_GunslingerCommentCodeEnum a()
	{
		return this.a;
	}

	// Token: 0x06004074 RID: 16500 RVA: 0x00188304 File Offset: 0x00186504
	public void a(Xphw_GunslingerCommentCodeEnum A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004075 RID: 16501 RVA: 0x00188310 File Offset: 0x00186510
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06004076 RID: 16502 RVA: 0x00188318 File Offset: 0x00186518
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004077 RID: 16503 RVA: 0x00188324 File Offset: 0x00186524
	public eln()
	{
	}

	// Token: 0x06004078 RID: 16504 RVA: 0x0018832C File Offset: 0x0018652C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		d7o.a(this.a, this.b, false);
	}

	// Token: 0x04001BFC RID: 7164
	private new Xphw_GunslingerCommentCodeEnum a;

	// Token: 0x04001BFD RID: 7165
	private bool b;
}
