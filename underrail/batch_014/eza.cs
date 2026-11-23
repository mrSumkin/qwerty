using System;
using System.Runtime.Serialization;

// Token: 0x020018BC RID: 6332
[eiz("QRF")]
[Serializable]
public sealed class eza : ISerializable
{
	// Token: 0x06008662 RID: 34402 RVA: 0x0037B4A8 File Offset: 0x003796A8
	private eza(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("QRF:N");
		if (ell.a() >= 102)
		{
			this.b = (e3c)A_0.GetValue("QRF:S", typeof(e3c));
		}
		else
		{
			this.b = (A_0.GetBoolean("QRF:C") ? e3c.b : e3c.a);
		}
		if (ell.a() >= 532)
		{
			this.c = A_0.GetBoolean("QRF:R");
			return;
		}
		this.c = true;
	}

	// Token: 0x06008663 RID: 34403 RVA: 0x0037B544 File Offset: 0x00379744
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("QRF:N", this.a);
		info.AddValue("QRF:S", this.b);
		info.AddValue("QRF:R", this.c);
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06008664 RID: 34404 RVA: 0x0037B580 File Offset: 0x00379780
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06008665 RID: 34405 RVA: 0x0037B588 File Offset: 0x00379788
	// (set) Token: 0x06008666 RID: 34406 RVA: 0x0037B590 File Offset: 0x00379790
	public e3c State
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

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06008667 RID: 34407 RVA: 0x0037B59C File Offset: 0x0037979C
	public eei Value
	{
		get
		{
			if (!this.d)
			{
				this.a();
				this.d = true;
			}
			return this.e;
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06008668 RID: 34408 RVA: 0x0037B5BC File Offset: 0x003797BC
	// (set) Token: 0x06008669 RID: 34409 RVA: 0x0037B5C4 File Offset: 0x003797C4
	public bool Read
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

	// Token: 0x0600866A RID: 34410 RVA: 0x0037B5D0 File Offset: 0x003797D0
	public eza(eei A_0)
	{
		this.a = A_0.Name;
		this.b = e3c.a;
		this.e = A_0;
		this.d = true;
	}

	// Token: 0x0600866B RID: 34411 RVA: 0x0037B5FC File Offset: 0x003797FC
	private void a()
	{
		this.e = ao5.a(this.a);
	}

	// Token: 0x04003389 RID: 13193
	private string a;

	// Token: 0x0400338A RID: 13194
	private e3c b;

	// Token: 0x0400338B RID: 13195
	private bool c;

	// Token: 0x0400338C RID: 13196
	[NonSerialized]
	private bool d;

	// Token: 0x0400338D RID: 13197
	[NonSerialized]
	private eei e;
}
