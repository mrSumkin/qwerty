using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace TimelapseVertigo.Rules.Characters
{
	// Token: 0x02000025 RID: 37
	[eiz("S4")]
	[Serializable]
	public abstract class Stat<T> : ISerializable where T : struct
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00004128 File Offset: 0x00002328
		protected Stat(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() != 0)
			{
				this.a = (xx)A_0.GetValue("S4:C", typeof(xx));
				this.b = (T)((object)A_0.GetValue("S4:V", typeof(T)));
				this.c = (T)((object)A_0.GetValue("S4:MV", typeof(T)));
				if (ell.b() >= 5)
				{
					di7.ReadEvent<c1>("S4:VC", ref this.d, A_0);
					di7.ReadEvent<c1>("S4:MVC", ref this.e, A_0);
					return;
				}
				this.d = (EventHandler<c1>)A_0.GetValue("S4:VC", typeof(EventHandler<c1>));
				this.e = (EventHandler<c1>)A_0.GetValue("S4:MVC", typeof(EventHandler<c1>));
				return;
			}
			else
			{
				if (base.GetType() == typeof(Stat<T>))
				{
					this.a = (xx)A_0.GetValue("_Container", typeof(xx));
					this.b = (T)((object)A_0.GetValue("_Value", typeof(T)));
					this.c = (T)((object)A_0.GetValue("_ModifiedValue", typeof(T)));
					this.d = (EventHandler<c1>)A_0.GetValue("ValueChanged", typeof(EventHandler<c1>));
					this.e = (EventHandler<c1>)A_0.GetValue("ModifiedValueChanged", typeof(EventHandler<c1>));
					return;
				}
				this.a = (xx)A_0.GetValue("Stat`1+_Container", typeof(xx));
				this.b = (T)((object)A_0.GetValue("Stat`1+_Value", typeof(T)));
				this.c = (T)((object)A_0.GetValue("Stat`1+_ModifiedValue", typeof(T)));
				this.d = (EventHandler<c1>)A_0.GetValue("Stat`1+ValueChanged", typeof(EventHandler<c1>));
				this.e = (EventHandler<c1>)A_0.GetValue("Stat`1+ModifiedValueChanged", typeof(EventHandler<c1>));
				return;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004370 File Offset: 0x00002570
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("S4:C", this.a);
			info.AddValue("S4:V", this.b);
			info.AddValue("S4:MV", this.c);
			di7.WriteEvent<c1>("S4:VC", this.d, info);
			di7.WriteEvent<c1>("S4:MVC", this.e, info);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000043DC File Offset: 0x000025DC
		public xx e()
		{
			return this.a;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000043E4 File Offset: 0x000025E4
		public void a(xx A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000043F0 File Offset: 0x000025F0
		public T f()
		{
			return this.b;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000043FC File Offset: 0x000025FC
		public void a(T A_0)
		{
			if (!A_0.Equals(this.b))
			{
				T t = this.b;
				this.b = A_0;
				if (this.d != null)
				{
					this.d(this, new c1(t, A_0));
				}
				this.a(t, A_0);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004464 File Offset: 0x00002664
		public T g()
		{
			return this.c;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000446C File Offset: 0x0000266C
		internal void b(T A_0)
		{
			T t = this.c;
			T t2 = A_0;
			this.ah5(ref t2);
			this.c = t2;
			if (!t.Equals(t2) && this.e != null)
			{
				this.e(this, new c1(t, t2));
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000044D4 File Offset: 0x000026D4
		protected virtual void ah5(ref T A_0)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000044D8 File Offset: 0x000026D8
		public virtual T? atw()
		{
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000044F0 File Offset: 0x000026F0
		[CompilerGenerated]
		public void b(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004528 File Offset: 0x00002728
		[CompilerGenerated]
		public void a(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004560 File Offset: 0x00002760
		[CompilerGenerated]
		public void c(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.e;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004598 File Offset: 0x00002798
		[CompilerGenerated]
		public void d(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.e;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000045D0 File Offset: 0x000027D0
		protected Stat()
		{
			this.b(new EventHandler<c1>(this.lm));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000045EC File Offset: 0x000027EC
		protected Stat(xx A_0) : this(A_0, default(T))
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000460C File Offset: 0x0000280C
		protected Stat(T A_0) : this(null, A_0)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004618 File Offset: 0x00002818
		protected Stat(xx A_0, T A_1) : this()
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004630 File Offset: 0x00002830
		[dcc("S4:mOVC")]
		protected virtual void lm(object A_0, c1 A_1)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004634 File Offset: 0x00002834
		private void a(T A_0, T A_1)
		{
			dw3 dw = this.e() as dw3;
			if (dw != null)
			{
				dw.a(this, A_0, A_1);
			}
		}

		// Token: 0x04000129 RID: 297
		private xx a;

		// Token: 0x0400012A RID: 298
		private T b;

		// Token: 0x0400012B RID: 299
		private T c;

		// Token: 0x0400012C RID: 300
		[CompilerGenerated]
		private EventHandler<c1> d;

		// Token: 0x0400012D RID: 301
		[CompilerGenerated]
		private EventHandler<c1> e;
	}
}
