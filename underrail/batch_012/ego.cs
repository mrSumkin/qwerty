using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02000241 RID: 577
[eiz("SLE")]
[Serializable]
public sealed class ego : alr, c7t, a9q, bvq, ISerializable
{
	// Token: 0x06001054 RID: 4180 RVA: 0x00043A94 File Offset: 0x00041C94
	private ego(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<e4b>("SLE:A", ref this.a, A_0);
			this.b = A_0.GetBoolean("SLE:E");
			this.c = A_0.GetInt32("SLE:L");
			this.d = (Guid)A_0.GetValue("SLE:I", typeof(Guid));
			this.e = A_0.GetString("SLE:N");
			this.f = (ae8)A_0.GetValue("SLE:L1", typeof(ae8));
			return;
		}
		if (base.GetType() == typeof(ego))
		{
			this.a = (List<e4b>)A_0.GetValue("_Areas", typeof(List<e4b>));
			this.b = A_0.GetBoolean("_Enabled");
			this.c = A_0.GetInt32("_Layer");
			this.d = (Guid)A_0.GetValue("<Id>k__BackingField", typeof(Guid));
			this.e = A_0.GetString("<Name>k__BackingField");
			this.f = (ae8)A_0.GetValue("<Light>k__BackingField", typeof(ae8));
			return;
		}
		this.a = (List<e4b>)A_0.GetValue("SoftLightEmitter+_Areas", typeof(List<e4b>));
		this.b = A_0.GetBoolean("SoftLightEmitter+_Enabled");
		this.c = A_0.GetInt32("SoftLightEmitter+_Layer");
		this.d = (Guid)A_0.GetValue("SoftLightEmitter+<Id>k__BackingField", typeof(Guid));
		this.e = A_0.GetString("SoftLightEmitter+<Name>k__BackingField");
		this.f = (ae8)A_0.GetValue("SoftLightEmitter+<Light>k__BackingField", typeof(ae8));
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00043C8C File Offset: 0x00041E8C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<e4b>("SLE:A", this.a, info);
		info.AddValue("SLE:E", this.b);
		info.AddValue("SLE:L", this.c);
		info.AddValue("SLE:I", this.d);
		info.AddValue("SLE:N", this.e);
		info.AddValue("SLE:L1", this.f);
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06001056 RID: 4182 RVA: 0x00043D0C File Offset: 0x00041F0C
	// (set) Token: 0x06001057 RID: 4183 RVA: 0x00043D14 File Offset: 0x00041F14
	[Category("Meta")]
	public int Layer
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

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06001058 RID: 4184 RVA: 0x00043D20 File Offset: 0x00041F20
	// (set) Token: 0x06001059 RID: 4185 RVA: 0x00043D28 File Offset: 0x00041F28
	[ReadOnly(true)]
	[Category("System")]
	public Guid Id
	{
		get
		{
			return this.d;
		}
		private set
		{
			this.d = value;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600105A RID: 4186 RVA: 0x00043D34 File Offset: 0x00041F34
	// (set) Token: 0x0600105B RID: 4187 RVA: 0x00043D3C File Offset: 0x00041F3C
	[Category("System")]
	public string Name
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

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600105C RID: 4188 RVA: 0x00043D48 File Offset: 0x00041F48
	// (set) Token: 0x0600105D RID: 4189 RVA: 0x00043D50 File Offset: 0x00041F50
	[Category("Behavior")]
	public ae8 Light
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

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600105E RID: 4190 RVA: 0x00043D5C File Offset: 0x00041F5C
	// (set) Token: 0x0600105F RID: 4191 RVA: 0x00043D64 File Offset: 0x00041F64
	[Category("Behavior")]
	public bool Enabled
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

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06001060 RID: 4192 RVA: 0x00043D70 File Offset: 0x00041F70
	[Browsable(false)]
	public ReadOnlyCollection<e4b> Areas
	{
		get
		{
			return this.a.AsReadOnly();
		}
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00043D80 File Offset: 0x00041F80
	internal ego(string A_0)
	{
		this.Id = Guid.NewGuid();
		this.Name = A_0;
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00043DAC File Offset: 0x00041FAC
	public void b(e4b A_0)
	{
		if (this.a.Contains(A_0))
		{
			this.a.Remove(A_0);
		}
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00043DCC File Offset: 0x00041FCC
	public void a(e4b A_0)
	{
		if (!this.a.Contains(A_0))
		{
			this.a.Add(A_0);
		}
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00043DF0 File Offset: 0x00041FF0
	public void b()
	{
		foreach (e4b e4b in this.a)
		{
			e4b.c();
		}
		this.a.Clear();
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00043E54 File Offset: 0x00042054
	public void c()
	{
		foreach (e4b e4b in this.a)
		{
			e4b.g();
		}
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00043EAC File Offset: 0x000420AC
	public override string ToString()
	{
		return this.Id.ToString();
	}

	// Token: 0x04000978 RID: 2424
	private List<e4b> a = new List<e4b>();

	// Token: 0x04000979 RID: 2425
	private bool b = true;

	// Token: 0x0400097A RID: 2426
	private int c;

	// Token: 0x0400097B RID: 2427
	private Guid d;

	// Token: 0x0400097C RID: 2428
	private string e;

	// Token: 0x0400097D RID: 2429
	private ae8 f;
}
