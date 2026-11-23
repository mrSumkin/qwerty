using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x020018F5 RID: 6389
[eiz("D2")]
[Serializable]
public sealed class cqh : ISerializable
{
	// Token: 0x060087C4 RID: 34756 RVA: 0x00381234 File Offset: 0x0037F434
	private cqh(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("D2:C");
		this.b = A_0.GetString("D2:N");
		di7.ReadList<string>("D2:P", ref this.c, A_0);
		this.d = A_0.GetBoolean("D2:R");
		if (ell.a() >= 21)
		{
			this.e = A_0.GetString("D2:P");
			this.f = A_0.GetString("D2:A");
			if (ell.a() >= 49)
			{
				di7.ReadList<string>("D2:OR", ref this.g, A_0);
			}
		}
	}

	// Token: 0x060087C5 RID: 34757 RVA: 0x003812EC File Offset: 0x0037F4EC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("D2:C", this.a);
		info.AddValue("D2:N", this.b);
		di7.WriteList<string>("D2:P", this.c, info);
		di7.WriteList<string>("D2:OR", this.g, info);
		info.AddValue("D2:R", this.d);
		info.AddValue("D2:P", this.e);
		info.AddValue("D2:A", this.f);
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x060087C6 RID: 34758 RVA: 0x00381370 File Offset: 0x0037F570
	// (set) Token: 0x060087C7 RID: 34759 RVA: 0x00381378 File Offset: 0x0037F578
	[XmlAttribute]
	public string Code
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

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x060087C8 RID: 34760 RVA: 0x00381384 File Offset: 0x0037F584
	// (set) Token: 0x060087C9 RID: 34761 RVA: 0x0038138C File Offset: 0x0037F58C
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

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x060087CA RID: 34762 RVA: 0x00381398 File Offset: 0x0037F598
	[Browsable(false)]
	public List<string> Parameters
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x060087CB RID: 34763 RVA: 0x003813A0 File Offset: 0x0037F5A0
	// (set) Token: 0x060087CC RID: 34764 RVA: 0x003813A8 File Offset: 0x0037F5A8
	[XmlElement]
	[Browsable(false)]
	public bool Read
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

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x060087CD RID: 34765 RVA: 0x003813B4 File Offset: 0x0037F5B4
	// (set) Token: 0x060087CE RID: 34766 RVA: 0x003813BC File Offset: 0x0037F5BC
	public string Portrait
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

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x060087CF RID: 34767 RVA: 0x003813C8 File Offset: 0x0037F5C8
	// (set) Token: 0x060087D0 RID: 34768 RVA: 0x003813D0 File Offset: 0x0037F5D0
	public string Author
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

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x060087D1 RID: 34769 RVA: 0x003813DC File Offset: 0x0037F5DC
	[Browsable(false)]
	public List<string> OnReadJobs
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x060087D2 RID: 34770 RVA: 0x003813E4 File Offset: 0x0037F5E4
	public cqh()
	{
	}

	// Token: 0x060087D3 RID: 34771 RVA: 0x00381404 File Offset: 0x0037F604
	public cqh(string A_0, string A_1, params string[] A_2)
	{
		this.a = A_0;
		this.b = A_1;
		if (A_2 != null)
		{
			this.c = new List<string>(A_2);
		}
	}

	// Token: 0x060087D4 RID: 34772 RVA: 0x00381448 File Offset: 0x0037F648
	public cqh e()
	{
		cqh cqh = new cqh();
		cqh.a = this.a;
		cqh.b = this.b;
		cqh.d = this.d;
		cqh.f = this.Author;
		cqh.e = this.e;
		if (this.g != null)
		{
			cqh.g = new List<string>(this.g);
		}
		if (this.c != null)
		{
			cqh.c = new List<string>(this.c);
		}
		return cqh;
	}

	// Token: 0x060087D5 RID: 34773 RVA: 0x003814D0 File Offset: 0x0037F6D0
	public string i()
	{
		string a_ = this.a;
		object[] a_2 = this.c.ToArray();
		return qv.a(a_, a_2);
	}

	// Token: 0x0400357A RID: 13690
	private string a;

	// Token: 0x0400357B RID: 13691
	private string b;

	// Token: 0x0400357C RID: 13692
	private List<string> c = new List<string>();

	// Token: 0x0400357D RID: 13693
	private bool d;

	// Token: 0x0400357E RID: 13694
	private string e;

	// Token: 0x0400357F RID: 13695
	private string f;

	// Token: 0x04003580 RID: 13696
	private List<string> g = new List<string>();
}
