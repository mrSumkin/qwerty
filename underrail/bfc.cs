using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x0200067A RID: 1658
[eiz("LD1")]
[Serializable]
public sealed class bfc : ISerializable
{
	// Token: 0x06002A2B RID: 10795 RVA: 0x000EE034 File Offset: 0x000EC234
	private bfc(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LD1:I");
			this.b = A_0.GetString("LD1:N");
			this.c = A_0.GetString("LD1:P");
			this.d = A_0.GetBoolean("LD1:AR");
			if (ell.a() >= 247)
			{
				this.e = A_0.GetString("LD1:T");
			}
			if (ell.a() >= 248)
			{
				this.f = A_0.GetString("LD1:M");
			}
			if (ell.a() >= 447)
			{
				this.g = A_0.GetInt32("LD1:L");
			}
			else
			{
				this.g = 1;
			}
			if (ell.a() >= 461)
			{
				this.h = A_0.GetBoolean("LD1:R");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(bfc))
			{
				this.a = A_0.GetString("_Id");
				this.b = A_0.GetString("_Name");
				this.c = A_0.GetString("_Preview");
				this.d = A_0.GetBoolean("_AutoReveal");
				return;
			}
			this.a = A_0.GetString("LocaleDefinition+_Id");
			this.b = A_0.GetString("LocaleDefinition+_Name");
			this.c = A_0.GetString("LocaleDefinition+_Preview");
			this.d = A_0.GetBoolean("LocaleDefinition+_AutoReveal");
		}
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x000EE1CC File Offset: 0x000EC3CC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LD1:I", this.a);
		info.AddValue("LD1:N", this.b);
		info.AddValue("LD1:P", this.c);
		info.AddValue("LD1:AR", this.d);
		info.AddValue("LD1:T", this.e);
		info.AddValue("LD1:M", this.f);
		info.AddValue("LD1:L", this.g);
		info.AddValue("LD1:R", this.h);
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000EE264 File Offset: 0x000EC464
	// (set) Token: 0x06002A2E RID: 10798 RVA: 0x000EE26C File Offset: 0x000EC46C
	[XmlAttribute]
	public string Id
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000EE278 File Offset: 0x000EC478
	// (set) Token: 0x06002A30 RID: 10800 RVA: 0x000EE280 File Offset: 0x000EC480
	[XmlAttribute]
	public string Name
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000EE28C File Offset: 0x000EC48C
	// (set) Token: 0x06002A32 RID: 10802 RVA: 0x000EE294 File Offset: 0x000EC494
	[XmlAttribute]
	public string Preview
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06002A33 RID: 10803 RVA: 0x000EE2A0 File Offset: 0x000EC4A0
	// (set) Token: 0x06002A34 RID: 10804 RVA: 0x000EE2A8 File Offset: 0x000EC4A8
	[XmlAttribute]
	public bool AutoReveal
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000EE2B4 File Offset: 0x000EC4B4
	// (set) Token: 0x06002A36 RID: 10806 RVA: 0x000EE2BC File Offset: 0x000EC4BC
	[XmlAttribute]
	public string LocaleType
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000EE2C8 File Offset: 0x000EC4C8
	// (set) Token: 0x06002A38 RID: 10808 RVA: 0x000EE2D0 File Offset: 0x000EC4D0
	[XmlAttribute]
	public string Music
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06002A39 RID: 10809 RVA: 0x000EE2DC File Offset: 0x000EC4DC
	// (set) Token: 0x06002A3A RID: 10810 RVA: 0x000EE2E4 File Offset: 0x000EC4E4
	[XmlAttribute]
	public int BaseLevel
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06002A3B RID: 10811 RVA: 0x000EE2F0 File Offset: 0x000EC4F0
	// (set) Token: 0x06002A3C RID: 10812 RVA: 0x000EE2F8 File Offset: 0x000EC4F8
	[XmlAttribute]
	public bool StaticRandomEvents
	{
		get
		{
			return this.h;
		}
		set
		{
			this.h = value;
		}
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x000EE304 File Offset: 0x000EC504
	public bfc()
	{
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x000EE314 File Offset: 0x000EC514
	public bfc(string A_0, string A_1)
	{
		czh.a(A_0, "id");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x000EE33C File Offset: 0x000EC53C
	public override string ToString()
	{
		return string.Format("{0} - {1}", this.a, this.b);
	}

	// Token: 0x040016F7 RID: 5879
	private string a;

	// Token: 0x040016F8 RID: 5880
	private string b;

	// Token: 0x040016F9 RID: 5881
	private string c;

	// Token: 0x040016FA RID: 5882
	private bool d;

	// Token: 0x040016FB RID: 5883
	private string e;

	// Token: 0x040016FC RID: 5884
	private string f;

	// Token: 0x040016FD RID: 5885
	private int g = 1;

	// Token: 0x040016FE RID: 5886
	private bool h;
}
