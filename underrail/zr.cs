using System;
using System.Runtime.Serialization;

// Token: 0x020011C8 RID: 4552
[eiz("M3")]
[Serializable]
public sealed class zr : s0
{
	// Token: 0x06006196 RID: 24982 RVA: 0x002A6C04 File Offset: 0x002A4E04
	private zr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("M3:M", typeof(cqh)) as cqh);
		this.b = A_0.GetBoolean("M3:P");
	}

	// Token: 0x06006197 RID: 24983 RVA: 0x002A6C40 File Offset: 0x002A4E40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M3:D", this.a);
		info.AddValue("M3:P", this.b);
	}

	// Token: 0x06006198 RID: 24984 RVA: 0x002A6C6C File Offset: 0x002A4E6C
	public cqh b()
	{
		return this.a;
	}

	// Token: 0x06006199 RID: 24985 RVA: 0x002A6C74 File Offset: 0x002A4E74
	public void a(cqh A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600619A RID: 24986 RVA: 0x002A6C80 File Offset: 0x002A4E80
	public bool a()
	{
		return this.b;
	}

	// Token: 0x0600619B RID: 24987 RVA: 0x002A6C88 File Offset: 0x002A4E88
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x002A6C94 File Offset: 0x002A4E94
	public override string ej()
	{
		return "Documents";
	}

	// Token: 0x0600619D RID: 24989 RVA: 0x002A6C9C File Offset: 0x002A4E9C
	public zr()
	{
	}

	// Token: 0x0600619E RID: 24990 RVA: 0x002A6CA8 File Offset: 0x002A4EA8
	public override string ek(e3q A_0)
	{
		if (A_0 != null && this.a != null && !string.IsNullOrEmpty(this.a.Name))
		{
			return string.Format("'{0}' от {1}", this.a.Name, this.a.Author) + ((!this.a.Read) ? " (НОВОЕ!)" : "");
		}
		return "#ERROR: Document not found";
	}

	// Token: 0x0600619F RID: 24991 RVA: 0x002A6D28 File Offset: 0x002A4F28
	public override string el(e3q A_0)
	{
		string format = "Тема: {0}\r\nАвтор: {1}\r\n\r\n{2}";
		object arg = this.a.Name;
		object arg2 = this.a.Author;
		string a_ = this.a.Code;
		object[] a_2 = this.a.Parameters.ToArray();
		return string.Format(format, arg, arg2, qv.a(a_, a_2));
	}

	// Token: 0x060061A0 RID: 24992 RVA: 0x002A6D78 File Offset: 0x002A4F78
	public override bool em(e3q A_0)
	{
		return this.a != null && !string.IsNullOrEmpty(this.a.Name);
	}

	// Token: 0x060061A1 RID: 24993 RVA: 0x002A6D9C File Offset: 0x002A4F9C
	public override void en(e3q A_0, c5x A_1)
	{
		if (this.a != null && !this.a.Read)
		{
			this.a.Read = true;
			dv0.a(this.a);
		}
	}

	// Token: 0x060061A2 RID: 24994 RVA: 0x002A6DD0 File Offset: 0x002A4FD0
	public override string eo(e3q A_0)
	{
		if (A_0 != null && this.a != null && !string.IsNullOrEmpty(this.a.Name))
		{
			return this.a.i();
		}
		return "#ERROR: Document not found";
	}

	// Token: 0x060061A3 RID: 24995 RVA: 0x002A6E0C File Offset: 0x002A500C
	public override string ep(e3q A_0)
	{
		if (A_0 != null && this.a != null && !string.IsNullOrEmpty(this.a.Name))
		{
			return "Прочитать сообщение: " + string.Format("'{0}' от {1}", this.a.Name, this.a.Author) + ((!this.a.Read) ? " (НОВОЕ!)" : "");
		}
		return "#ERROR: Document not found";
	}

	// Token: 0x04002976 RID: 10614
	private cqh a;

	// Token: 0x04002977 RID: 10615
	private bool b;
}
