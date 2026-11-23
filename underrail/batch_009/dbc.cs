using System;
using System.Runtime.Serialization;

// Token: 0x02000136 RID: 310
[eiz("LPR")]
[Serializable]
public sealed class dbc : ISerializable
{
	// Token: 0x06000792 RID: 1938 RVA: 0x00020940 File Offset: 0x0001EB40
	private dbc(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("LPR:I", typeof(Guid));
			this.b = A_0.GetString("LPR:N");
			this.c = A_0.GetBoolean("LPR:IR");
			return;
		}
		if (base.GetType() == typeof(dbc))
		{
			this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.b = A_0.GetString("_Name");
			this.c = A_0.GetBoolean("_IsRequired");
			return;
		}
		this.a = (Guid)A_0.GetValue("LogicProviderRef+_Id", typeof(Guid));
		this.b = A_0.GetString("LogicProviderRef+_Name");
		this.c = A_0.GetBoolean("LogicProviderRef+_IsRequired");
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00020A40 File Offset: 0x0001EC40
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LPR:I", this.a);
		info.AddValue("LPR:N", this.b);
		info.AddValue("LPR:IR", this.c);
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00020A7C File Offset: 0x0001EC7C
	public Guid b()
	{
		return this.a;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00020A84 File Offset: 0x0001EC84
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00020A90 File Offset: 0x0001EC90
	public string c()
	{
		return this.b;
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00020A98 File Offset: 0x0001EC98
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00020AA4 File Offset: 0x0001ECA4
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00020AAC File Offset: 0x0001ECAC
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00020AB8 File Offset: 0x0001ECB8
	public dbc()
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00020AC0 File Offset: 0x0001ECC0
	public dbc(string A_0, bool A_1)
	{
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00020AD8 File Offset: 0x0001ECD8
	public dbc(Guid A_0, bool A_1)
	{
		this.a = A_0;
		this.c = A_1;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00020AF0 File Offset: 0x0001ECF0
	public dbc(Guid A_0, string A_1, bool A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00020B10 File Offset: 0x0001ED10
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

	// Token: 0x0600079F RID: 1951 RVA: 0x00020B7C File Offset: 0x0001ED7C
	internal bool d()
	{
		return this.b() != Guid.Empty || !string.IsNullOrEmpty(this.c());
	}

	// Token: 0x0400056F RID: 1391
	private Guid a;

	// Token: 0x04000570 RID: 1392
	private string b;

	// Token: 0x04000571 RID: 1393
	private bool c;
}
