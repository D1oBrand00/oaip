r i p t " >  
 	  
 	 	 / /   T h i s   f u n c t i o n   i s   u s e d   t o   p r e s e n t   t h e   i n s t a l l   s u m m a r y   i n f o r m a t i o n .  
 	 	 f u n c t i o n   s h o w R e s u l t ( s C l a s s N a m e ,   f D i s p l a y R e s u l t )  
 	 	 {  
 	 	 	 s h o w C l a s s ( s C l a s s N a m e ,   f D i s p l a y R e s u l t ) ;  
  
 	 	 	 / /   E x p a n d   a l l   n o d e s   a n d   t u r n   o f f   a l l   c l a s s e s   e x c e p t   r e s u l t .  
 	 	 	 i f   ( t r u e   = =   f D i s p l a y R e s u l t )    
 	 	 	 {  
 	 	 	 	 / /   U n c h e c k   a l l   c h e c k b o x e s .  
 	 	 	 	 d o c u m e n t . g e t E l e m e n t B y I d ( " e r r C B " ) . c h e c k e d   =   f a l s e ;  
 	 	 	 	 d o c u m e n t . g e t E l e m e n t B y I d ( " v b e C B " ) . c h e c k e d   =   f a l s e ;  
 	 	 	 	 d o c u m e n t . g e t E l e m e n t B y I d ( " m s g C B " ) . c h e c k e d   =   f a l s e ;  
 	 	 	 	 d o c u m e n t . g e t E l e m e n t B y I d ( " t C B " ) . c h e c k e d   =   f a l s e ;  
 	 	 	    
 	 	 	 	 / /   H i d e   r e s p e c t i v e   c o n t e n t s .  
 	 	 	 	 s h o w C l a s s ( " e r r " , 0 ) ;  
 	 	 	 	 s h o w C l a s s ( " v b e " , 0 ) ;  
 	 	 	 	 s h o w C l a s s ( " m s g " , 0 ) ;  
 	 	 	 	 s h o w C l a s s ( " d b g " , 0 ) ;  
 	 	 	 	 s h o w C l a s s ( " i t n " , 0 ) ;  
 	 	 	 	 s h o w C l a s s ( " t " , 0 ) ;  
 	 	 	 	 a d d R u l e ( d o c u m e n t . s t y l e S h e e t s [ 0 ] ,   " d i v . s e c t i o n H d r " ,   " d i s p l a y : n o n e " ) ; 	    
 	 	 	 }  
 	 	 	 e l s e  
 	 	 	 {  
 	 	 	 	 a d d R u l e ( d o c u m e n t . s t y l e S