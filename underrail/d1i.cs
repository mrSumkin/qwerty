using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A4 RID: 4260
[eiz("RIFPJ")]
[Serializable]
public sealed class d1i : cze, ISerializable
{
	// Token: 0x0600595B RID: 22875 RVA: 0x0026A16C File Offset: 0x0026836C
	private d1i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("RIFPJ:IC");
		this.b = A_0.GetInt32("RIFPJ:S");
		this.c = A_0.GetBoolean("RIFPJ:SG");
	}

	// Token: 0x0600595C RID: 22876 RVA: 0x0026A1C4 File Offset: 0x002683C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RIFPJ:IC", this.a);
		info.AddValue("RIFPJ:S", this.b);
		info.AddValue("RIFPJ:SG", this.c);
	}

	// Token: 0x0600595D RID: 22877 RVA: 0x0026A20C File Offset: 0x0026840C
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600595E RID: 22878 RVA: 0x0026A214 File Offset: 0x00268414
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600595F RID: 22879 RVA: 0x0026A220 File Offset: 0x00268420
	public int c()
	{
		return this.b;
	}

	// Token: 0x06005960 RID: 22880 RVA: 0x0026A228 File Offset: 0x00268428
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005961 RID: 22881 RVA: 0x0026A234 File Offset: 0x00268434
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06005962 RID: 22882 RVA: 0x0026A23C File Offset: 0x0026843C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005963 RID: 22883 RVA: 0x0026A248 File Offset: 0x00268448
	public d1i()
	{
	}

	// Token: 0x06005964 RID: 22884 RVA: 0x0026A264 File Offset: 0x00268464
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			coh coh = serviceOrThrow.aqu().v().a(this.a, this.b, this.c);
			if (coh != null)
			{
				a7v.a(new aub(coh));
			}
		}
	}

	// Token: 0x040023EC RID: 9196
	private new string a;

	// Token: 0x040023ED RID: 9197
	private int b = 1;

	// Token: 0x040023EE RID: 9198
	private bool c = true;
}
