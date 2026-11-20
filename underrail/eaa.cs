using System;
using System.Runtime.Serialization;

// Token: 0x0200013A RID: 314
[eiz("RR")]
[Serializable]
public sealed class eaa : ISerializable
{
	// Token: 0x060007B3 RID: 1971 RVA: 0x00021140 File Offset: 0x0001F340
	private eaa(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("RR:I", typeof(Guid));
			this.b = A_0.GetString("RR:N");
			this.c = A_0.GetBoolean("RR:IR");
			return;
		}
		if (base.GetType() == typeof(eaa))
		{
			this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.b = A_0.GetString("_Name");
			this.c = A_0.GetBoolean("_IsRequired");
			return;
		}
		this.a = (Guid)A_0.GetValue("RendererRef+_Id", typeof(Guid));
		this.b = A_0.GetString("RendererRef+_Name");
		this.c = A_0.GetBoolean("RendererRef+_IsRequired");
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00021240 File Offset: 0x0001F440
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RR:I", this.a);
		info.AddValue("RR:N", this.b);
		info.AddValue("RR:IR", this.c);
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0002127C File Offset: 0x0001F47C
	public Guid b()
	{
		return this.a;
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00021284 File Offset: 0x0001F484
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00021290 File Offset: 0x0001F490
	public string c()
	{
		return this.b;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00021298 File Offset: 0x0001F498
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x000212A4 File Offset: 0x0001F4A4
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x000212AC File Offset: 0x0001F4AC
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000212B8 File Offset: 0x0001F4B8
	public eaa()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x000212C0 File Offset: 0x0001F4C0
	public eaa(string A_0, bool A_1)
	{
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x000212D8 File Offset: 0x0001F4D8
	public eaa(Guid A_0, bool A_1)
	{
		this.a = A_0;
		this.c = A_1;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x000212F0 File Offset: 0x0001F4F0
	public eaa(Guid A_0, string A_1, bool A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00021310 File Offset: 0x0001F510
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"[Id: ",
			this.b().ToString(),
			", Name: ",
			this.c(),
			", IsRequired: ",
			this.a().ToString(),
			"]"
		});
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x0002137C File Offset: 0x0001F57C
	internal bool d()
	{
		return this.b() != Guid.Empty || !string.IsNullOrEmpty(this.c());
	}

	// Token: 0x04000578 RID: 1400
	private Guid a;

	// Token: 0x04000579 RID: 1401
	private string b;

	// Token: 0x0400057A RID: 1402
	private bool c;
}
