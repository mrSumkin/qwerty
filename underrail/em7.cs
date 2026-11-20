using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Game.Data;

// Token: 0x0200113E RID: 4414
[eiz("DELMA")]
[Serializable]
public sealed class em7 : Aspect<c5x>, ISerializable
{
	// Token: 0x06005E70 RID: 24176 RVA: 0x0028091C File Offset: 0x0027EB1C
	private em7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (MapNodeState)A_0.GetValue("DELMA:S", typeof(MapNodeState));
		if (ell.a() >= 430)
		{
			di7.ReadList<string>("DELMA:R", ref this.b, A_0);
			di7.ReadList<string>("DELMA:P", ref this.c, A_0);
		}
		else
		{
			string @string = A_0.GetString("DELMA:C");
			this.b = new List<string>();
			this.c = new List<string>();
			this.b.Add(@string);
		}
		if (ell.a() >= 433)
		{
			this.d = A_0.GetString("DELMA:K");
		}
	}

	// Token: 0x06005E71 RID: 24177 RVA: 0x002809EC File Offset: 0x0027EBEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DELMA:S", this.a);
		di7.WriteList<string>("DELMA:R", this.b, info);
		di7.WriteList<string>("DELMA:P", this.c, info);
		info.AddValue("DELMA:K", this.d);
	}

	// Token: 0x06005E72 RID: 24178 RVA: 0x00280A4C File Offset: 0x0027EC4C
	public List<string> e()
	{
		return this.b;
	}

	// Token: 0x06005E73 RID: 24179 RVA: 0x00280A54 File Offset: 0x0027EC54
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005E74 RID: 24180 RVA: 0x00280A60 File Offset: 0x0027EC60
	public List<string> d()
	{
		return this.c;
	}

	// Token: 0x06005E75 RID: 24181 RVA: 0x00280A68 File Offset: 0x0027EC68
	public void b(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005E76 RID: 24182 RVA: 0x00280A74 File Offset: 0x0027EC74
	public MapNodeState b()
	{
		return this.a;
	}

	// Token: 0x06005E77 RID: 24183 RVA: 0x00280A7C File Offset: 0x0027EC7C
	public void a(MapNodeState A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E78 RID: 24184 RVA: 0x00280A88 File Offset: 0x0027EC88
	public string a()
	{
		return this.d;
	}

	// Token: 0x06005E79 RID: 24185 RVA: 0x00280A90 File Offset: 0x0027EC90
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005E7A RID: 24186 RVA: 0x00280A9C File Offset: 0x0027EC9C
	public em7(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002586 RID: 9606
	private MapNodeState a;

	// Token: 0x04002587 RID: 9607
	private List<string> b = new List<string>();

	// Token: 0x04002588 RID: 9608
	private List<string> c = new List<string>();

	// Token: 0x04002589 RID: 9609
	private string d;
}
