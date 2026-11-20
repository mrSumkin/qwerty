using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001054 RID: 4180
[eiz("QDJJ")]
[Serializable]
public sealed class d9m : cze, ISerializable
{
	// Token: 0x060056C7 RID: 22215 RVA: 0x00260680 File Offset: 0x0025E880
	private d9m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("QDJJ:J", ref this.a, A_0);
		this.b = A_0.GetBoolean("QDJJ:R");
		this.c = A_0.GetInt32("QDJJ:D");
	}

	// Token: 0x060056C8 RID: 22216 RVA: 0x002606D4 File Offset: 0x0025E8D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("QDJJ:J", this.a, info);
		info.AddValue("QDJJ:R", this.b);
		info.AddValue("QDJJ:D", this.c);
	}

	// Token: 0x060056C9 RID: 22217 RVA: 0x00260714 File Offset: 0x0025E914
	public List<cze> c()
	{
		return this.a;
	}

	// Token: 0x060056CA RID: 22218 RVA: 0x0026071C File Offset: 0x0025E91C
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060056CB RID: 22219 RVA: 0x00260728 File Offset: 0x0025E928
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060056CC RID: 22220 RVA: 0x00260730 File Offset: 0x0025E930
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060056CD RID: 22221 RVA: 0x0026073C File Offset: 0x0025E93C
	public int b()
	{
		return this.c;
	}

	// Token: 0x060056CE RID: 22222 RVA: 0x00260744 File Offset: 0x0025E944
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060056CF RID: 22223 RVA: 0x00260750 File Offset: 0x0025E950
	public d9m()
	{
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x00260768 File Offset: 0x0025E968
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null && this.a.Count > 0)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			if (this.c > 0)
			{
				qy.ad().Add(new bm3(this.c));
			}
			foreach (cze a_ in this.a)
			{
				qy.ad().Add(new a4s(a_, new ar7(A_0), new ar7(A_1), null));
			}
			serviceOrThrow.aqw().ActionManager.g9(qy, atp.a);
			if (this.b)
			{
				dz6.a(qy);
			}
		}
	}

	// Token: 0x04002332 RID: 9010
	private new List<cze> a = new List<cze>();

	// Token: 0x04002333 RID: 9011
	private bool b;

	// Token: 0x04002334 RID: 9012
	private int c;
}
