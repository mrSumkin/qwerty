using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000157 RID: 343
[eiz("DM")]
[Serializable]
public class azm : ISerializable
{
	// Token: 0x06000888 RID: 2184 RVA: 0x00023EA4 File Offset: 0x000220A4
	protected azm(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.b = A_0.GetString("DM:DN");
			this.c = A_0.GetString("DM:DD");
			this.d = (d55)A_0.GetValue("DM:SE", typeof(d55));
			di7.ReadList<string>("DM:LL", ref this.e, A_0);
			di7.ReadList<ax8>("DM:A", ref this.f, A_0);
			this.g = A_0.GetBoolean("DM:IC");
			if (ell.b() >= 24)
			{
				this.h = A_0.GetBoolean("DM:P");
			}
			else
			{
				this.h = !this.g;
			}
			if (ell.b() >= 44)
			{
				this.i = A_0.GetInt32("DM:C");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(azm))
			{
				this.b = A_0.GetString("_DialogName");
				this.c = A_0.GetString("_DialogDescription");
				this.d = (d55)A_0.GetValue("_StartElement", typeof(d55));
				this.e = (List<string>)A_0.GetValue("_LocalizationLanguages", typeof(List<string>));
				this.f = (List<ax8>)A_0.GetValue("_Actors", typeof(List<ax8>));
				this.g = A_0.GetBoolean("_IsCancellable");
				return;
			}
			this.b = A_0.GetString("DialogModel+_DialogName");
			this.c = A_0.GetString("DialogModel+_DialogDescription");
			this.d = (d55)A_0.GetValue("DialogModel+_StartElement", typeof(d55));
			this.e = (List<string>)A_0.GetValue("DialogModel+_LocalizationLanguages", typeof(List<string>));
			this.f = (List<ax8>)A_0.GetValue("DialogModel+_Actors", typeof(List<ax8>));
			this.g = A_0.GetBoolean("DialogModel+_IsCancellable");
		}
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x000240F0 File Offset: 0x000222F0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DM:DN", this.b);
		info.AddValue("DM:DD", this.c);
		info.AddValue("DM:SE", this.d);
		di7.WriteList<string>("DM:LL", this.e, info);
		di7.WriteList<ax8>("DM:A", this.f, info);
		info.AddValue("DM:IC", this.g);
		info.AddValue("DM:P", this.h);
		info.AddValue("DM:C", this.i);
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00024188 File Offset: 0x00022388
	public string e()
	{
		return this.b;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00024190 File Offset: 0x00022390
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002419C File Offset: 0x0002239C
	public string f()
	{
		return this.c;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x000241A4 File Offset: 0x000223A4
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x000241B0 File Offset: 0x000223B0
	public d55 b()
	{
		return this.d;
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x000241B8 File Offset: 0x000223B8
	public void a(d55 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x000241C4 File Offset: 0x000223C4
	public List<string> d()
	{
		return this.e;
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x000241CC File Offset: 0x000223CC
	public List<ax8> a()
	{
		return this.f;
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x000241D4 File Offset: 0x000223D4
	public bool c()
	{
		return this.g;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x000241DC File Offset: 0x000223DC
	public void b(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x000241E8 File Offset: 0x000223E8
	public bool g()
	{
		return this.h;
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x000241F0 File Offset: 0x000223F0
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000241FC File Offset: 0x000223FC
	public azm()
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0002422C File Offset: 0x0002242C
	public azm(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00024264 File Offset: 0x00022464
	public azm(string A_0, string A_1)
	{
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x040005B1 RID: 1457
	public const string a = "udlg";

	// Token: 0x040005B2 RID: 1458
	private string b;

	// Token: 0x040005B3 RID: 1459
	private string c;

	// Token: 0x040005B4 RID: 1460
	private d55 d;

	// Token: 0x040005B5 RID: 1461
	private List<string> e = new List<string>
	{
		"English"
	};

	// Token: 0x040005B6 RID: 1462
	private List<ax8> f = new List<ax8>();

	// Token: 0x040005B7 RID: 1463
	private bool g = true;

	// Token: 0x040005B8 RID: 1464
	private bool h;

	// Token: 0x040005B9 RID: 1465
	public int i;
}
