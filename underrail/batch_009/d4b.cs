using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001046 RID: 4166
[eiz("SILSJ")]
[Serializable]
public sealed class d4b : cze
{
	// Token: 0x06005648 RID: 22088 RVA: 0x0025EA38 File Offset: 0x0025CC38
	private d4b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SILSJ:N");
		this.b = A_0.GetBoolean("SILSJ:E");
		this.c = (Guid?)A_0.GetValue("SILSJ:I", typeof(Guid?));
		this.d = A_0.GetString("SILSJ:A");
	}

	// Token: 0x06005649 RID: 22089 RVA: 0x0025EAA0 File Offset: 0x0025CCA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SILSJ:N", this.a);
		info.AddValue("SILSJ:E", this.b);
		info.AddValue("SILSJ:I", this.c);
		info.AddValue("SILSJ:A", this.d);
	}

	// Token: 0x0600564A RID: 22090 RVA: 0x0025EB00 File Offset: 0x0025CD00
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600564B RID: 22091 RVA: 0x0025EB08 File Offset: 0x0025CD08
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x0025EB14 File Offset: 0x0025CD14
	public string c()
	{
		return this.a;
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x0025EB1C File Offset: 0x0025CD1C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x0025EB28 File Offset: 0x0025CD28
	public string a()
	{
		return this.d;
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x0025EB30 File Offset: 0x0025CD30
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x0025EB3C File Offset: 0x0025CD3C
	public Guid? d()
	{
		return this.c;
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x0025EB44 File Offset: 0x0025CD44
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005652 RID: 22098 RVA: 0x0025EB50 File Offset: 0x0025CD50
	public d4b()
	{
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x0025EB5C File Offset: 0x0025CD5C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = cze.a(this.d, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (aud.a(this.c.Value) as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			ah7 ah = null;
			foreach (ejt ejt in c5x.RaysEmitters)
			{
				bsf bsf = ejt as bsf;
				if (bsf != null && bsf.Definition != null && bsf.Definition.Name == this.a)
				{
					ah = bsf.Definition;
					break;
				}
			}
			if (ah != null)
			{
				ah.Enabled = this.b;
				ah.d();
			}
		}
	}

	// Token: 0x04002307 RID: 8967
	private new string a;

	// Token: 0x04002308 RID: 8968
	private bool b;

	// Token: 0x04002309 RID: 8969
	private Guid? c;

	// Token: 0x0400230A RID: 8970
	private string d;
}
