using System;
using System.Runtime.Serialization;

// Token: 0x02000FCB RID: 4043
[eiz("JIPAOBC")]
[Serializable]
public sealed class ck2 : dnh
{
	// Token: 0x0600531D RID: 21277 RVA: 0x0024FB50 File Offset: 0x0024DD50
	private ck2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("JIPAOBC:I");
		this.b = A_0.GetString("JIPAOBC:F");
		this.c = A_0.GetString("JIPAOBC:C");
	}

	// Token: 0x0600531E RID: 21278 RVA: 0x0024FB98 File Offset: 0x0024DD98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JIPAOBC:I", this.a);
		info.AddValue("JIPAOBC:F", this.b);
		info.AddValue("JIPAOBC:C", this.c);
	}

	// Token: 0x0600531F RID: 21279 RVA: 0x0024FBE0 File Offset: 0x0024DDE0
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005320 RID: 21280 RVA: 0x0024FBE8 File Offset: 0x0024DDE8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005321 RID: 21281 RVA: 0x0024FBF4 File Offset: 0x0024DDF4
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005322 RID: 21282 RVA: 0x0024FBFC File Offset: 0x0024DDFC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005323 RID: 21283 RVA: 0x0024FC08 File Offset: 0x0024DE08
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005324 RID: 21284 RVA: 0x0024FC10 File Offset: 0x0024DE10
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005325 RID: 21285 RVA: 0x0024FC1C File Offset: 0x0024DE1C
	public ck2()
	{
	}

	// Token: 0x06005326 RID: 21286 RVA: 0x0024FC28 File Offset: 0x0024DE28
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null)
		{
			bool flag = false;
			string name = aya.a(this.c);
			dic classPropertyValue = service.aqu().r().GetClassPropertyValue<dic>(name);
			if (classPropertyValue != null)
			{
				if (this.b == null)
				{
				}
				flag = (classPropertyValue.a() == this.b);
			}
			return flag ^ this.a;
		}
		return false;
	}

	// Token: 0x040021FB RID: 8699
	private bool a;

	// Token: 0x040021FC RID: 8700
	private string b;

	// Token: 0x040021FD RID: 8701
	private string c;
}
