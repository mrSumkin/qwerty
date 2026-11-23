using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001038 RID: 4152
[eiz("CQJ0")]
[Serializable]
public sealed class a0b : cze, ISerializable
{
	// Token: 0x060055C3 RID: 21955 RVA: 0x0025CD08 File Offset: 0x0025AF08
	private a0b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("CQJ0:QN");
		this.a = A_0.GetBoolean("CQJ0:PE");
	}

	// Token: 0x060055C4 RID: 21956 RVA: 0x0025CD3C File Offset: 0x0025AF3C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CQJ0:QN", this.b);
		info.AddValue("CQJ0:PE", this.a);
	}

	// Token: 0x060055C5 RID: 21957 RVA: 0x0025CD68 File Offset: 0x0025AF68
	public string a()
	{
		return this.b;
	}

	// Token: 0x060055C6 RID: 21958 RVA: 0x0025CD70 File Offset: 0x0025AF70
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x0025CD7C File Offset: 0x0025AF7C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060055C8 RID: 21960 RVA: 0x0025CD84 File Offset: 0x0025AF84
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x0025CD90 File Offset: 0x0025AF90
	public a0b()
	{
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x0025CDA0 File Offset: 0x0025AFA0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<cnk>().aqz().atc(this.a(), this.a);
	}

	// Token: 0x040022DE RID: 8926
	private new bool a = true;

	// Token: 0x040022DF RID: 8927
	private string b;
}
